﻿using CodeGeneratorAttributesLibrary;

namespace DocumentVersionManager.BaseModels.Entities
{
    public class ProcessFlowGroup : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false, false, true)]
        public string ProcessFlowGroupName { get; init; }

        public string DefaultTestingMode { get; init; } = string.Empty;

        [BaseModelBasicAttribute(64, 0, false, false, false)]
        public string Description { get; init; } = string.Empty;
        // public ICollection<ModelVersion> ModelVersions { get; set; }

        public ICollection<ModelType> ModelTypes { get; set; }
    }
}
