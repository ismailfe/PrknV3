using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using Emikon.Parkon.Model;
using System;
using System.Collections;
using System.Linq;

namespace Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IDB_EMKPRKNEntitiesUnitOfWork>(() => new DB_EMKPRKNEntitiesUnitOfWork(() => new DB_EMKPRKNEntities()));
        }
    }
}