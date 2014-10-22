﻿using System;
using Meta.Net.Abstract;

namespace Meta.Net.Objects
{
    //[Serializable]
    public class CheckConstraint : UserTableBasedObject
    {
        public static readonly string DefaultDescription = "Check Constraint";

        public override string Description
        {
            get { return DefaultDescription; }
        }

        public string ColumnName { get; set; }
        public string Definition { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsNotForReplication { get; set; }
        public bool IsNotTrusted { get; set; }
        public bool IsSystemNamed { get; set; }
        public bool IsTableConstraint { get; set; }

        private static void Init(CheckConstraint checkConstraint, UserTable userTable, string objectName)
        {
            checkConstraint.UserTable = userTable;
            checkConstraint.ObjectName = GetDefaultObjectName(checkConstraint, objectName);
            checkConstraint.ColumnName = "";
            checkConstraint.Definition = "";
            checkConstraint.IsDisabled = false;
            checkConstraint.IsNotForReplication = false;
            checkConstraint.IsNotTrusted = false;
            checkConstraint.IsSystemNamed = false;
            checkConstraint.IsTableConstraint = true;
        }

        public CheckConstraint(UserTable userTable, string objectName)
        {
            Init(this, userTable, objectName);
        }

        public CheckConstraint()
        {
            
        }

        /// <summary>
        /// Deep Clone and Shallow Clone... Leaf Node.
        /// A clone of this class's isntance specific metadata.
        /// </summary>
        /// <param name="checkConstraint">The check constraint to clone.</param>
        /// <returns>A clone of this class's isntance specific metadata.</returns>
        public static CheckConstraint Clone(CheckConstraint checkConstraint)
        {
            return new CheckConstraint
            {
                ObjectName = checkConstraint.ObjectName,
                ColumnName = checkConstraint.ColumnName,
                Definition = checkConstraint.Definition,
                IsDisabled = checkConstraint.IsDisabled,
                IsNotForReplication = checkConstraint.IsNotForReplication,
                IsNotTrusted = checkConstraint.IsNotTrusted,
                IsSystemNamed = checkConstraint.IsSystemNamed,
                IsTableConstraint = checkConstraint.IsTableConstraint
            };
        }

        //public static bool CompareDefinitions(CheckConstraint sourceCheckConstraint, CheckConstraint targetCheckConstraint)
        //{
        //    if (!CompareObjectNames(sourceCheckConstraint, targetCheckConstraint))
        //        return false;

        //    if (sourceCheckConstraint.IsDisabled != targetCheckConstraint.IsDisabled)
        //        return false;

        //    if (sourceCheckConstraint.IsNotForReplication != targetCheckConstraint.IsNotForReplication)
        //        return false;

        //    if (sourceCheckConstraint.IsNotTrusted != targetCheckConstraint.IsNotTrusted)
        //        return false;

        //    if (sourceCheckConstraint.IsSystemNamed != targetCheckConstraint.IsSystemNamed)
        //        return false;

        //    if (sourceCheckConstraint.IsTableConstraint != targetCheckConstraint.IsTableConstraint)
        //        return false;

        //    if (StringComparer.OrdinalIgnoreCase.Compare(
        //        sourceCheckConstraint.ColumnName, targetCheckConstraint.ColumnName) != 0)
        //        return false;

        //    return DataProperties.DefinitionComparer.Compare(
        //        sourceCheckConstraint.Definition, targetCheckConstraint.Definition) == 0;
        //}

        //public static void GenerateCreateScripts(
        //    DataContext sourceDataContext, DataContext targetDataContext,
        //    CheckConstraint checkConstraint, DataSyncActionsCollection dataSyncActions, DataProperties dataProperties)
        //{
        //    var dataSyncAction = DataActionFactory.CreateCheckConstraint(sourceDataContext, targetDataContext, checkConstraint);
        //    if (dataSyncAction != null)
        //        dataSyncActions.Add(dataSyncAction);
        //}

        //public static void GenerateDropScripts(
        //    DataContext sourceDataContext, DataContext targetDataContext,
        //    CheckConstraint checkConstraint, DataSyncActionsCollection dataSyncActions, DataProperties dataProperties)
        //{
        //    var dataSyncAction = DataActionFactory.DropCheckConstraint(sourceDataContext, targetDataContext, checkConstraint);
        //    if (dataSyncAction != null)
        //        dataSyncActions.Add(dataSyncAction);
        //}

        //public CheckConstraint(SerializationInfo info, StreamingContext context)
        //{
        //    // Holding off on the serialzation in this manner because, this is
        //    // extremely complicated to do in this manner do to data object
        //    // associations, especially
        //    // Set Null Members
        //    UserTable = null;

        //    // Deserialize Members
        //    ObjectName = info.GetString("ObjectName");
        //    Description = info.GetString("Description");
        //    ColumnName = info.GetString("ColumnName");
        //    Definition = info.GetString("Definition");
        //    IsDisabled = info.GetBoolean("IsDisabled");
        //    IsNotForReplication = info.GetBoolean("IsNotForReplication");
        //    IsNotTrusted = info.GetBoolean("IsNotTrusted");
        //    IsSystemNamed = info.GetBoolean("IsSystemNamed");
        //    IsTableConstraint = info.GetBoolean("IsTableConstraint");
        //}

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    // Holding off on the serialzation in this manner because, this is
        //    // extremely complicated to do in this manner do to data object
        //    // associations, especially
        //    // Serialize Members
        //    info.AddValue("ObjectName", ObjectName);
        //    info.AddValue("Description", Description);
        //    info.AddValue("ColumnName", ColumnName);
        //    info.AddValue("Definition", Definition);
        //    info.AddValue("IsDisabled", IsDisabled);
        //    info.AddValue("IsNotForReplication", IsNotForReplication);
        //    info.AddValue("IsNotTrusted", IsNotTrusted);
        //    info.AddValue("IsSystemNamed", IsSystemNamed);
        //    info.AddValue("IsTableConstraint", IsTableConstraint);
        //}

        //public static CheckConstraint FromJson(string json)
        //{
        //    return JsonConvert.DeserializeObject<CheckConstraint>(json);
        //}

        //public static string ToJson(CheckConstraint checkConstraint, Formatting formatting = Formatting.Indented)
        //{
        //    return JsonConvert.SerializeObject(checkConstraint, formatting);
        //}
    }
}