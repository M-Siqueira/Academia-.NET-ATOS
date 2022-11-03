// var numero = 1;

// if(numero == "1"){
//     alert("==compara apenas valores");

// }

// var mensagem;

// if(numero === "1"){ //teste a variavel e o tipo para retornar true.
//     mensagem = "nunca executa";
//     alert(mensagem);
// }else{
//     mensagem = "numero é diferente de string com ===";
//     alert(mensagem);
// }

// var x = (numero === "1")? "nunca executya": "diferente de";
// alert(x);

// var laranja = 6;

// switch(laranja){
//     case 3:
//         alert("fazer um copo de suco");
//         break;
//     case 6:
//         alert("fazer um copo de suco");
//         break;
//     case 9:
//         alert("fazer um copo de suco");
//         break;
//     default:
//         break;

//         alert("faz quantos possivel");
// }

// var pessoas = ["jose","joao","maria","ana"]
// for (var i = 0; i < pessoas.length; i++){
//     alert(pessoas[i])
// }

// var nome = "";

// var pessoa = {nome:"iara", sobrenome:"almenida"};

// for (x in pessoa) {
//     nome += " " + pessoa[x] + " ";
// }
// alert(nome);

// var impar;

// for (i = 0; i < 10 ; i++) {
//     if(i %2 == 0) {
//         //par

//     }else{
//         alert(i);
//     }
// }


// var x = 0;

// for (i = 1; i < 101 ; i++) {

//      x += i;

// }
// alert(x);





function funcao(){
    var teste = "teste";
    var valor = 1;

    if (valor > 0){
        var teste= "teste";
    }

    alert(teste);

}


function minhaFuncao() {
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
    }

    function mensagem(){
        var x = document.getElementById("valor1");
        var y = document.getElementById("valor2");

        var soma = parseInt(x.value) + parseInt(y.value);

        alert("saldo: "+ soma);

        if(soma %2 == 0){
            //botao azul
        document.getElementById("botao").style.background="blue";


        }else{
            //botao verde
            document.getElementById("botao").style.background="green";

        }

    }