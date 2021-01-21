namespace Exercicio3.Modelos
{
    public class ControleRemoto
    {
        private Televisao _televisao;
        private bool ControleEstaDessincronizado => _televisao is null;

        public void SincronizarComTelevisao(Televisao televisao) => _televisao = televisao;

        public void AumentarVolume()
        {
            if (ControleEstaDessincronizado) return;
            _televisao.AumentarVolume();
        }
        
        public void DiminuirVolume()
        {
            if (ControleEstaDessincronizado) return;
            _televisao.DiminuirVolume();
        }
        
        public void MudarParaCanalEspecifico(int canalEspecifico)
        {
            if (ControleEstaDessincronizado) return;
            _televisao.MudarParaCanalEspecifico(canalEspecifico);
        }
        
        public void ProximoCanal()
        {
            if (ControleEstaDessincronizado) return;
            _televisao.ProximoCanal();
        }
        
        public void CanalAnterior()
        {
            if (ControleEstaDessincronizado) return;
            _televisao.CanalAnterior();
        }
    }
}