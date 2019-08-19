using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public abstract class Entity
    {
        protected int id;

        public Entity()
        {

        }

        public Entity(int id)
        {
            this.id = id;
        }

        public int Id => id;
    }
}
