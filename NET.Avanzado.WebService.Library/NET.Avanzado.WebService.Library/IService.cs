using System.Runtime.Serialization;
using System.ServiceModel;

namespace NET.Avanzado.WebService.Library
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Office GetOfficeData();
    }

    [DataContract]
    public class Office
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}