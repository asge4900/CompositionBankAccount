using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public abstract class Entity
    {
        #region Fields
        protected int id;
        #endregion

        #region Constuctors
        public Entity()
        {

        }
        public Entity(int id)
        {
            this.id = id;
        }
        #endregion

        #region Properties
        public int Id => id;
        #endregion
    }
}
