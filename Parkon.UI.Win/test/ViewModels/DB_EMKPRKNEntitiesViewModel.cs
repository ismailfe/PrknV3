using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using Emikon.Parkon.UI.Win.test.DB_EMKPRKNEntitiesDataModel;

namespace Emikon.Parkon.UI.Win.test.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the DB_EMKPRKNEntities data model.
    /// </summary>
    public partial class DB_EMKPRKNEntitiesViewModel : DocumentsViewModel<DB_EMKPRKNEntitiesModuleDescription, IDB_EMKPRKNEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of DB_EMKPRKNEntitiesViewModel as a POCO view model.
        /// </summary>
        public static DB_EMKPRKNEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new DB_EMKPRKNEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the DB_EMKPRKNEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DB_EMKPRKNEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected DB_EMKPRKNEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override DB_EMKPRKNEntitiesModuleDescription[] CreateModules() {
			return new DB_EMKPRKNEntitiesModuleDescription[] {
                new DB_EMKPRKNEntitiesModuleDescription( "Customer Contact", "Customer_ContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customer_Contact)),
                new DB_EMKPRKNEntitiesModuleDescription( "Customer Section", "Customer_SectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customer_Section)),
                new DB_EMKPRKNEntitiesModuleDescription( "Customer Type", "Customer_TypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customer_Type)),
                new DB_EMKPRKNEntitiesModuleDescription( "Customers", "CustomersCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new DB_EMKPRKNEntitiesModuleDescription( "Keyword", "KeywordCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Keyword)),
                new DB_EMKPRKNEntitiesModuleDescription( "Licenses", "LicensesCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Licenses)),
                new DB_EMKPRKNEntitiesModuleDescription( "Project Detail", "Project_DetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Project_Detail)),
                new DB_EMKPRKNEntitiesModuleDescription( "Project Rev", "Project_RevCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Project_Rev)),
                new DB_EMKPRKNEntitiesModuleDescription( "Projects", "ProjectsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Projects)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Address", "Store_AddressCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Address)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Address Col", "Store_AddressColCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_AddressCol)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Address Pos", "Store_AddressPosCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_AddressPos)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Address Row", "Store_AddressRowCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_AddressRow)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Address Zone", "Store_AddressZoneCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_AddressZone)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Brand", "Store_BrandCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Brand)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Location", "Store_LocationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Location)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Logs", "Store_LogsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Logs)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Out Action", "Store_OutActionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_OutAction)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Product", "Store_ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Product)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Product Block", "Store_ProductBlockCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_ProductBlock)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Product Group", "Store_ProductGroupCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_ProductGroup)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Product Type", "Store_ProductTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_ProductType)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Product Unit", "Store_ProductUnitCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_ProductUnit)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Warehouse", "Store_WarehouseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_Warehouse)),
                new DB_EMKPRKNEntitiesModuleDescription( "Store Warehouse Out", "Store_WarehouseOutCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Store_WarehouseOut)),
                new DB_EMKPRKNEntitiesModuleDescription( "Supplier Contact", "Supplier_ContactCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Supplier_Contact)),
                new DB_EMKPRKNEntitiesModuleDescription( "Supplier Section", "Supplier_SectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Supplier_Section)),
                new DB_EMKPRKNEntitiesModuleDescription( "Supplier Type", "Supplier_TypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Supplier_Type)),
                new DB_EMKPRKNEntitiesModuleDescription( "Suppliers", "SuppliersCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Suppliers)),
                new DB_EMKPRKNEntitiesModuleDescription( "test", "testCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.test)),
                new DB_EMKPRKNEntitiesModuleDescription( "Title", "TitleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Title)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Access", "User_AccessCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Access)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Authorization", "User_AuthorizationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Authorization)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Department", "User_DepartmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Department)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Level", "User_LevelCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Level)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Logs", "User_LogsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Logs)),
                new DB_EMKPRKNEntitiesModuleDescription( "User Online", "User_OnlineCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.User_Online)),
                new DB_EMKPRKNEntitiesModuleDescription( "Users", "UsersCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
                new DB_EMKPRKNEntitiesModuleDescription( "Zone", "ZoneCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Zone)),
			};
        }
                		protected override void OnActiveModuleChanged(DB_EMKPRKNEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class DB_EMKPRKNEntitiesModuleDescription : ModuleDescription<DB_EMKPRKNEntitiesModuleDescription> {
        public DB_EMKPRKNEntitiesModuleDescription(string title, string documentType, string group, Func<DB_EMKPRKNEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}