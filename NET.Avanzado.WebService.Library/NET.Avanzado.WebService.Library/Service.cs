namespace NET.Avanzado.WebService.Library
{
    public class Service : IService
    {
        public Office GetOfficeData()
        {
            return new Office
            {
                Name = "Cubits SRL",
                Address = "Fanny Jacovsky 3539, San Francisco, Córdoba"
            };
        }
    }
}