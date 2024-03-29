﻿using CodeGeneratorAttributesLibrary;

namespace DocumentVersionManager.BaseModels.Entities
{

    public class ModelType : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string ModelTypeName { get; private set; } = string.Empty;
        //  [ProjectBaseModelsAttribute(30, 2, true, true, true, true, false, "")]


        public ICollection<Model> Models { get; set; } //This is for navigation property.// to be removed if i want  to strictly follow domain driven design

    }
}
