using DocumentVersionManager.DomainBase.Base;
namespace DocumentVersionManager.Domain.Entities
{
    public partial class Specification  : BaseEntity
        {
            public string ModelName    { get; init; }  = string.Empty; 
            public int ModelVersionId    { get; init; } 
            public int Capacity    { get; init; } 
            public DateTime Timestamp    { get; init; } 
            public string UserName    { get; init; }  = string.Empty; 
            public Double NominalOutput    { get; init; } 
            public decimal NominalOutputPercentage    { get; init; } 
            public decimal NonlinearityPercentage    { get; init; } 
            public int MinimumDeadLoad    { get; init; } 
            public Double vMin    { get; init; } 
            public int nMax    { get; init; } 
            public int SafeLoad    { get; init; } 
            public int UltimateLoad    { get; init; } 
            public string ShellMaterialName    { get; init; }  = string.Empty; 
            public Boolean Alloy    { get; init; } 
            public int DefaultCableLength    { get; init; } 
            public int NumberOfGauges    { get; init; } 
            public int Resistance    { get; init; } 
            public string CCNumber    { get; init; }  = string.Empty; 
            public string Class    { get; init; }  = string.Empty; 
            public string Application    { get; init; }  = string.Empty; 
            public int TemperingHardnessLow    { get; init; } 
            public int TemperingHardnessHigh    { get; init; } 
            public string NTEPCertificationId    { get; init; }  = string.Empty; 
            public DateTime NTEPCertificationTimestamp    { get; init; } 
            public string OIMLCertificationId    { get; init; }  = string.Empty; 
            public DateTime OIMLCertificationTimestamp    { get; init; } 
            public ModelVersion ModelVersion    { get; init; } 
            public ShellMaterial ShellMaterial    { get; init; } 
            private  List <CapacityTestPoint> _CapacityTestPoints { get;  set;}  = new List<CapacityTestPoint>();
            public  IReadOnlyCollection<CapacityTestPoint> CapacityTestPoints => _CapacityTestPoints;
            public Guid GuidId    { get; init; } 
        }
}