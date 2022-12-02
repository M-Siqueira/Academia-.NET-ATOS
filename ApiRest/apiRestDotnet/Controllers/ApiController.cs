using apiRestDotnet.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiRestDotnet.Controllers
{

    [ApiController]
    [Route("api")]

    public class ApiController : Controller
    {


        //[HttpGet("nome")]
        //public string RetornaNome()
        //{
        //    return "marcelo";
        //}




        //[HttpGet("idade")]
        //public int RetornaIdade()
        //{
        //    return 33;
        //}



        //[HttpPost("nomeRetorno/{nome}")]
        //public string PegaNome([FromRoute] string nome)
        //{
        //    return nome;
        //}



        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult>getAllAsync(
            [FromServices] Context contexto)
        {

            var pessoas = await contexto
                .Pessoa
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }



        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync(
            [FromServices] Context contexto,
            [FromRoute] int id )
        {

            var pessoas = await contexto
                .Pessoa.AsNoTracking().FirstOrDefaultAsync(p => p.id == id);

            return pessoas == null ? NotFound() : Ok(pessoas);
        }




        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync(
           [FromServices] Context contexto,
           [FromBody] Pessoa pessoa
            )
        {

            try
            {

                await contexto.Pessoa.AddAsync(pessoa);
                await contexto.SaveChangesAsync();

                return Created($"api/pessoas/{pessoa.id}", pessoa);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }


        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
          [FromServices] Context contexto,
          [FromBody] Pessoa pessoa,
          [FromRoute] int id
           )
        {

            var p = await contexto.Pessoa.FirstOrDefaultAsync(x => x.id == id); 



            try
            {

               p.nome = pessoa.nome;

                contexto.Pessoa.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
    }
}
