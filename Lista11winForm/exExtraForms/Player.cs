using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exExtraForms
{
    internal class Player
    {

        private string _playerName;
        private string _playerEmail; 

        public Player(string playerName, string playerEmail)
        {

            this._playerName = playerName;
           this._playerEmail = playerEmail;
           
        }

        public string PlayerName { get => _playerName; set => _playerName = value; }
       public string PlayerEmail { get => _playerEmail; set => _playerEmail = value; }
    }

   





}
