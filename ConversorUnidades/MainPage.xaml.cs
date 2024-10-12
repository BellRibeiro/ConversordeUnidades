namespace ConversorUnidades
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void onConverterClickedDis(object sender, EventArgs e)
        {
            // Obter os valores de entrada
            double valor = Convert.ToDouble(NumDist.Text);
            string unidadeOrigem = selectDistOrigem.SelectedItem.ToString();
            string unidadeDestino = selectDistDestino.SelectedItem.ToString();

            // Conversão
            double resultado = ConverterDistancia(valor, unidadeOrigem, unidadeDestino);
            resDist.Text = $"{resultado} {unidadeDestino}";
        }

        private void onConverterClickedPeso(object sender, EventArgs e)
        {
            // Obter os valores de entrada
            double valor = Convert.ToDouble(NumPeso.Text);
            string unidadeOrigem = selectPesoOrigem.SelectedItem.ToString();
            string unidadeDestino = selectPesoDestino.SelectedItem.ToString();

            // Conversão
            double resultado = ConverterPeso(valor, unidadeOrigem, unidadeDestino);
            resPeso.Text = $"{resultado} {unidadeDestino}";
        }

        private void onConverterClickedTemp(object sender, EventArgs e)
        {
            // Obter os valores de entrada
            double valor = Convert.ToDouble(NumTemp.Text);
            string unidadeOrigem = selectTempOrigem.SelectedItem.ToString();
            string unidadeDestino = selectTempDestino.SelectedItem.ToString();

            // Conversão
            double resultado = ConverterTemperatura(valor, unidadeOrigem, unidadeDestino);
            resTemp.Text = $"{resultado} {unidadeDestino}";
        }

        private double ConverterDistancia(double valor, string origem, string destino)
        {
            // Conversão de distância
            if (origem == "Metros")
            {
                if (destino == "Quilômetros") return valor / 1000;
                if (destino == "Milhas") return valor * 0.000621371;
            }
            else if (origem == "Quilômetros")
            {
                if (destino == "Metros") return valor * 1000;
                if (destino == "Milhas") return valor * 0.621371;
            }
            else if (origem == "Milhas")
            {
                if (destino == "Metros") return valor / 0.000621371;
                if (destino == "Quilômetros") return valor / 0.621371;
            }

            return valor; // Se a origem e destino forem iguais
        }

        private double ConverterPeso(double valor, string origem, string destino)
        {
            // Conversão de peso
            if (origem == "Grama")
            {
                if (destino == "Quilograma") return valor / 1000;
                if (destino == "Libra") return valor * 0.00220462;
            }
            else if (origem == "Quilograma")
            {
                if (destino == "Grama") return valor * 1000;
                if (destino == "Libra") return valor * 2.20462;
            }
            else if (origem == "Libra")
            {
                if (destino == "Grama") return valor / 0.00220462;
                if (destino == "Quilograma") return valor / 2.20462;
            }

            return valor; // Se a origem e destino forem iguais
        }

        private double ConverterTemperatura(double valor, string origem, string destino)
        {
            // Conversão de temperatura
            if (origem == "Celsius")
            {
                if (destino == "Fahrenheit") return (valor * 9 / 5) + 32;
                if (destino == "Kelvin") return valor + 273.15;
            }
            else if (origem == "Fahrenheit")
            {
                if (destino == "Celsius") return (valor - 32) * 5 / 9;
                if (destino == "Kelvin") return (valor - 32) * 5 / 9 + 273.15;
            }
            else if (origem == "Kelvin")
            {
                if (destino == "Celsius") return valor - 273.15;
                if (destino == "Fahrenheit") return (valor - 273.15) * 9 / 5 + 32;
            }

            return valor; // Se a origem e destino forem iguais
        }
    }
}

    
    
