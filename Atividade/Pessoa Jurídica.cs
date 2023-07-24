namespace Atividade
{
    public class Pessoa_Juridica : Cliente
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 0.20f; // Calcula 20% de imposto para pessoa jurídica
            this.total = this.valor + this.valor_imposto;
        }
    }
}
