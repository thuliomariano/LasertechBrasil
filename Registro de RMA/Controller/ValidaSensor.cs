using System;

namespace Registro_de_RMA.Modelo
{
    public class Validacao
    {

        //pendência de validação, sera o ultimo ponto a ser verificado
        private String mensagem = "";
        public Validacao(Sensor sensor)
        {
            if (sensor.NumeroDeSerie.Length > 9)
            {
                mensagem = "Favor Inserir no campo 'Número de série' valor menor que 9 caracteres!";
            }
            if (sensor.Cliente.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Cliente' valor menor que 50 caracteres!";
            }
            if (sensor.Rma.Length > 15)
            {
                mensagem = "Favor Inserir no campo 'RMA' valor menor que 15 caracteres!";
            }
            if (Convert.ToString(sensor.Patrimonio).Length > 15)
            {
                mensagem = "Favor Inserir no campo 'Patrimônio' valor menor que 15 caracteres!";
            }
            if (sensor.Recebimento.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Recebimento' valor menor que 50 caracteres!";
            }
            if (sensor.Os.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'OS' valor menor que 50 caracteres!";
            }
            if (sensor.Apontamento.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Apontamento' valor menor que 50 caracteres!";
            }
            if (sensor.Observacao.Length > 350)
            {
                mensagem = "Favor Inserir no campo 'Observação' valor menor que 350 caracteres!";
            }
            if (sensor.Status.Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Status' valor menor que 50 caracteres!";
            }
            if (Convert.ToString(sensor.SensorPrice).Length > 50)
            {
                mensagem = "Favor Inserir no campo 'Preço' valor menor que 50 caracteres!";
            }
            if (sensor.Lti.Length > 250)
            {
                mensagem = "Favor Inserir no campo 'Informações LTI' valor menor que 250 caracteres!";
            }
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
    }
}
