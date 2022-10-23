namespace WebApiAutores.Services
{
    public interface IService
    {
        void RealizarTarea();

    }

    public class ServicioA : IService
    {
        private readonly ILogger<ServicioA> logger;

        public ServicioA(ILogger<ServicioA> logger)
        {
            this.logger = logger;
        }
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }

    public class ServicioB : IService
    {
        public void RealizarTarea()
        {
            
        }
    }
}
