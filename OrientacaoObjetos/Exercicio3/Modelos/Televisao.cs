namespace Exercicio3.Modelos
{
    public class Televisao
    {
        private const int TotalCanais = 10;
        private const int PrimeiroCanal = 1;
        private const int VolumeMaximo = 10;
        private const int VolumeMinimo = 0;

        private int Volume { get; set; } = 1;
        private int Canal { get; set; } = PrimeiroCanal;
        
        private bool VolumeEstaNoMaximo => Volume == VolumeMaximo;
        private bool VolumeEstaNoMinimo => Volume == VolumeMinimo;
        
        private bool CanalEstaNoMaximo => Canal == TotalCanais;
        private bool CanalEstaNoPrimeiro => Canal == PrimeiroCanal;

        public string InfoDaTelevisao => @$"Canal: {Canal}
Volume: {Volume}";

        public void AumentarVolume()
        {
            if (VolumeEstaNoMaximo) return;
            Volume++;
        }
        
        public void DiminuirVolume()
        {
            if (VolumeEstaNoMinimo) return;
            Volume--;
        }
        
        private bool CanalEstaDentroDoLimite(int canal) => canal < PrimeiroCanal || canal > TotalCanais;
        
        public void MudarParaCanalEspecifico(int canalEspecifico)
        {
            if (CanalEstaDentroDoLimite(canalEspecifico)) return;
            Canal = canalEspecifico;
        }
        
        public void ProximoCanal()
        {
            if (CanalEstaNoMaximo) return;
            Canal++;
        }
        
        public void CanalAnterior()
        {
            if (CanalEstaNoPrimeiro) return;
            Canal--;
        }
    }
}