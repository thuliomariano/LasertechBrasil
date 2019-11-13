using Registro_de_RMA.Controller;
using Registro_de_RMA.DAL;
using Registro_de_RMA.Entities;
using System;

namespace Registro_de_RMA.Modelo
{
    public class Controle
    {
        private String mensagem;

        public string Mensagem { get => mensagem; set => mensagem = value; }

        public String CadastrarArm(Arm arm)
        {

            ValidaArm validaArm = new ValidaArm(arm);
            if (validaArm.Mensagem.Equals(""))
            {
                ArmDao armDao = new ArmDao();
                return Mensagem = armDao.cadastrarArm(arm);
            }
            else
            {
                Mensagem = validaArm.Mensagem;
            }

            return Mensagem;
        }
    }
}
