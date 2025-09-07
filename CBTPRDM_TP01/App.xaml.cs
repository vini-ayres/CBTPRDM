// Vinicius do Nascimento Ayres(CB3025675)
// Matheus Leandro Terra Luciano(CB3024881)

namespace CBTPRDM_TP01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}