using CodeGeneratorAttributesLibrary;

namespace DocumentVersionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("ModelVersion", "TestPoints")]
    public class TestPoint : BaseEntity
    {
        [BaseModelBasicAttribute(true, true)]
        public int ModelVersionId { get; init; }
        [BaseModelBasicAttribute(32, 0, true, true, false)]
        public string ModelName { get; init; } = string.Empty;

        public int Order { get; init; }// this is the order of the test points   

        [BaseModelBasicAttribute(true)]
        public int CapacityTestPoint { get; init; }// these are the test points/weights for the capacity test
                                                   // we dont need to specify capacity again because the Modelversion already has it

        public ModelVersion ModelVersion { get; set; }

    }
}
