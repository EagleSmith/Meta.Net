﻿using Meta.Net.Abstract;

namespace Meta.Net.Objects
{
    //[Serializable]
    public class UserDefinedDataType : SchemaBasedObject
    {
        public static readonly string DefaultDescription = "User-Defined Data Type";

        public override string Description
        {
            get { return DefaultDescription; }
        }

        public string DataType { get; set; }
        public long MaxLength { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public string Collation { get; set; }
        public bool HasDefault { get; set; }
        public bool IsUserDefined { get; set; }
        public bool IsAssemblyType { get; set; }
        public bool IsNullable { get; set; }

        private static void Init(UserDefinedDataType userDefinedDataType, Schema schema, string objectName)
        {
            userDefinedDataType.Schema = schema;
            userDefinedDataType.ObjectName = GetDefaultObjectName(userDefinedDataType, objectName);
            userDefinedDataType.Collation = "";
            userDefinedDataType.DataType = "int";
            userDefinedDataType.HasDefault = false;
            userDefinedDataType.IsAssemblyType = false;
            userDefinedDataType.IsNullable = false;
            userDefinedDataType.IsUserDefined = false;
            userDefinedDataType.MaxLength = 0;
            userDefinedDataType.Precision = 0;
            userDefinedDataType.Scale = 0;
        }

        public UserDefinedDataType(Schema schema, string objectName)
        {
            Init(this, schema, objectName);
        }
        
        public UserDefinedDataType()
        {
            
        }

        /// <summary>
        /// Deep Clone and Shallow Clone... Leaf Node.
        /// A clone of this class's isntance specific metadata.
        /// </summary>
        /// <param name="userDefinedDataType">The user-defined data type to clone.</param>
        /// <returns>A clone of this class's isntance specific metadata.</returns>
        public static UserDefinedDataType Clone(UserDefinedDataType userDefinedDataType)
        {
            return new UserDefinedDataType
            {
                ObjectName = userDefinedDataType.ObjectName,
                Collation = userDefinedDataType.Collation,
                DataType = userDefinedDataType.DataType,
                HasDefault = userDefinedDataType.HasDefault,
                IsAssemblyType = userDefinedDataType.IsAssemblyType,
                IsNullable = userDefinedDataType.IsNullable,
                IsUserDefined = userDefinedDataType.IsUserDefined,
                MaxLength = userDefinedDataType.MaxLength,
                Precision = userDefinedDataType.Precision,
                Scale = userDefinedDataType.Scale
            };
        }

        //public static bool CompareDefinitions(UserDefinedDataType sourceUserDefinedDataType, UserDefinedDataType targetUserDefinedDataType)
        //{
        //    if (!CompareObjectNames(sourceUserDefinedDataType, targetUserDefinedDataType))
        //        return false;

        //    if (sourceUserDefinedDataType.HasDefault != targetUserDefinedDataType.HasDefault)
        //        return false;

        //    if (sourceUserDefinedDataType.IsAssemblyType != targetUserDefinedDataType.IsAssemblyType)
        //        return false;

        //    if (sourceUserDefinedDataType.IsNullable != targetUserDefinedDataType.IsNullable)
        //        return false;

        //    if (sourceUserDefinedDataType.IsUserDefined != targetUserDefinedDataType.IsUserDefined)
        //        return false;

        //    if (sourceUserDefinedDataType.MaxLength != targetUserDefinedDataType.MaxLength)
        //        return false;

        //    if (sourceUserDefinedDataType.Precision != targetUserDefinedDataType.Precision)
        //        return false;

        //    if (sourceUserDefinedDataType.Scale != targetUserDefinedDataType.Scale)
        //        return false;

        //    if (StringComparer.OrdinalIgnoreCase.Compare(sourceUserDefinedDataType.Collation, targetUserDefinedDataType.Collation) != 0)
        //        return false;

        //    return StringComparer.OrdinalIgnoreCase.Compare(
        //        sourceUserDefinedDataType.DataType, targetUserDefinedDataType.DataType) == 0;
        //}

        //public static bool CompareObjectNames(UserDefinedDataType sourceUserDefinedDataType, UserDefinedDataType targetUserDefinedDataType, StringComparer stringComparer = null)
        //{
        //    if (stringComparer == null)
        //        stringComparer = StringComparer.OrdinalIgnoreCase;

        //    return stringComparer.Compare(sourceUserDefinedDataType.ObjectName, targetUserDefinedDataType.ObjectName) == 0;
        //}
        
        //public static void GenerateCreateScripts(
        //    DataContext sourceDataContext, DataContext targetDataContext,
        //    UserDefinedDataType userDefinedDataType, DataSyncActionsCollection dataSyncActions, DataProperties dataProperties)
        //{
        //    var dataSyncAction = DataActionFactory.CreateUserDefinedDataType(sourceDataContext, targetDataContext, userDefinedDataType);
        //    if (dataSyncAction != null)
        //        dataSyncActions.Add(dataSyncAction);
        //}

        //public static void GenerateDropScripts(
        //    DataContext sourceDataContext, DataContext targetDataContext,
        //    UserDefinedDataType userDefinedDataType, DataSyncActionsCollection dataSyncActions, DataProperties dataProperties)
        //{
        //    if (!dataProperties.TightSync)
        //        return;

        //    var dataSyncAction = DataActionFactory.DropUserDefinedDataType(sourceDataContext, targetDataContext, userDefinedDataType);
        //    if (dataSyncAction != null)
        //        dataSyncActions.Add(dataSyncAction);
        //}
        
        //public UserDefinedDataType(SerializationInfo info, StreamingContext context)
        //{
        //    // Holding off on the serialzation in this manner because, this is
        //    // extremely complicated to do in this manner do to data object
        //    // associations, especially
        //    // Set Null Members
        //    Schema = null;

        //    // Deserialize Members
        //    ObjectName = info.GetString("ObjectName");
        //    Description = info.GetString("Description");
        //    Collation = info.GetString("Collation");
        //    DataType = info.GetString("DataType");
        //    Description = info.GetString("Description");
        //    HasDefault = info.GetBoolean("HasDefault");
        //    IsAssemblyType = info.GetBoolean("IsAssemblyType");
        //    IsNullable = info.GetBoolean("IsNullable");
        //    IsUserDefined = info.GetBoolean("IsUserDefined");
        //    MaxLength = info.GetInt32("MaxLength");
        //    Precision = info.GetInt32("Precision");
        //    Scale = info.GetInt32("Scale");
        //}

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    // Holding off on the serialzation in this manner because, this is
        //    // extremely complicated to do in this manner do to data object
        //    // associations, especially
        //    // Serialize Members
        //    info.AddValue("ObjectName", ObjectName);
        //    info.AddValue("Description", Description);
        //    info.AddValue("Collation", Collation);
        //    info.AddValue("DataType", DataType);
        //    info.AddValue("Description", Description);
        //    info.AddValue("HasDefault", HasDefault);
        //    info.AddValue("IsAssemblyType", IsAssemblyType);
        //    info.AddValue("IsNullable", IsNullable);
        //    info.AddValue("IsUserDefined", IsUserDefined);
        //    info.AddValue("MaxLength", MaxLength);
        //    info.AddValue("Precision", Precision);
        //    info.AddValue("Scale", Scale);
        //}

        //public static string ToJson(UserDefinedDataType userDefinedDataType, Formatting formatting = Formatting.Indented)
        //{
        //    return JsonConvert.SerializeObject(userDefinedDataType, formatting);
        //}

        //public static UserDefinedDataType FromJson(string json)
        //{
        //    return JsonConvert.DeserializeObject<UserDefinedDataType>(json);
        //}
    }
}