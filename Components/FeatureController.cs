//using System.Xml;

namespace CreativeWizardry.Modules.ModuleStarter.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for ModuleStarter
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<ModuleStarterInfo> colModuleStarters = GetModuleStarters(ModuleID);
        //if (colModuleStarters.Count != 0)
        //{
        //    strXML += "<ModuleStarters>";

        //    foreach (ModuleStarterInfo objModuleStarter in colModuleStarters)
        //    {
        //        strXML += "<ModuleStarter>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objModuleStarter.Content) + "</content>";
        //        strXML += "</ModuleStarter>";
        //    }
        //    strXML += "</ModuleStarters>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlModuleStarters = DotNetNuke.Common.Globals.GetContent(Content, "ModuleStarters");
        //foreach (XmlNode xmlModuleStarter in xmlModuleStarters.SelectNodes("ModuleStarter"))
        //{
        //    ModuleStarterInfo objModuleStarter = new ModuleStarterInfo();
        //    objModuleStarter.ModuleId = ModuleID;
        //    objModuleStarter.Content = xmlModuleStarter.SelectSingleNode("content").InnerText;
        //    objModuleStarter.CreatedByUser = UserID;
        //    AddModuleStarter(objModuleStarter);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<ModuleStarterInfo> colModuleStarters = GetModuleStarters(ModInfo.ModuleID);

        //foreach (ModuleStarterInfo objModuleStarter in colModuleStarters)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objModuleStarter.Content, objModuleStarter.CreatedByUser, objModuleStarter.CreatedDate, ModInfo.ModuleID, objModuleStarter.ItemId.ToString(), objModuleStarter.Content, "ItemId=" + objModuleStarter.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
