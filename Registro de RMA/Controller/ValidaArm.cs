using Registro_de_RMA.Entities;
using System;

namespace Registro_de_RMA.Controller
{
    class ValidaArm
    {
        //pendência de validação, sera o ultimo ponto a ser verificado
        private String mensagem = "";
        public ValidaArm(Arm arm)
        {
            if (arm.Patrimonio.Length >= 10)
            {
                mensagem = "Favor Inserir no campo 'Patrimnio' um valor menor que 10 caracteres!";
            }
            if (arm.VersaoDeHardwarePC.Length > 80)
            {
                mensagem = "Favor Inserir no campo 'PCI hardware' um valor menor que 80 caracteres!";
            }
            if (arm.VersaoDeSoftwarerPC.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'PCI Software' um valor menor que 50 caracteres!";
            }
            if (arm.Mac.Length > 18)
            {
                mensagem = "Favor Inserir no campo 'MAC adress' um valor menor que 12 caracteres!";
            }
            if (Convert.ToString(arm.SerialIris).Length > 15)
            {
                mensagem = "Favor Inserir no campo 'IRIS' valor menor que 15 caracteres!";
            }
            if (Convert.ToString(arm.SerialColibri).Length > 15)
            {
                mensagem = "Favor Inserir no campo 'Colibri' valor menor que 15 caracteres!";
            }
            if (arm.WindowsCe.Length > 30)
            {
                mensagem = "Favor Inserir no campo 'Windows CE' valor menor que 30 caracteres!";
            }
            if (arm.BootLoader.Length > 30)
            {
                mensagem = "Favor Inserir no campo 'BootLoader' valor menor que 30 caracteres!";
            }
            if (arm.SoftwareTrufix.Length > 100)
            {
                mensagem = "Favor Inserir no campo 'Software Trufix' valor menor que 100 caracteres!";
            }
            if (arm.SoftwareToradex.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Software Toradex' valor menor que 80 caracteres!";
            }
            if (arm.PatrimonioPcAtualizado.Length >= 10)
            {
                mensagem = "Favor Inserir no campo 'Patrimônio atualizado' valor menor que 10 caracteres!";
            }
            if (arm.VersaoDeHardwareAtualizadoPc.Length > 80)
            {
                mensagem = "Favor Inserir no campo 'Hardware PCI atualizado' valor menor que 80 caracteres!";
            }
            if (arm.VersaoDeSoftwareAtualizadoPC.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Software PCI atualizado' valor menor que 50 caracteres!";
            }
            if (arm.WindowsCeAtualizado.Length >50)
            {
                mensagem = "Favor Inserir no campo 'Windows CE atualizado' valor menor que 50 caracteres!";
            }
            if (arm.BootLoaderAtualizado.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Bootloader atualizado' valor menor que 50 caracteres!";
            }
            if (arm.SoftwareTrufixAtualizado.Length > 100)
            {
                mensagem = "Favor Inserir no campo 'Software Trufix atualizado' valor menor que 100 caracteres!";
            }
            if (arm.SoftwareToradexAtualizado.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Software Toradex atualizado' valor menor que 50 caracteres!";
            }
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}

