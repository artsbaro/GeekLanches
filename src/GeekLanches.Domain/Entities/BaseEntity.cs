using System;

namespace GeekLanches.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime? DataUltimaAlteracao { get; set; }
        public virtual bool Ativo { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}