﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace TowMotorDLL {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("InsertTowMotorEngineOffEntry")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class InsertTowMotorEngineOffEntry : global::System.Data.DataSet {
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public InsertTowMotorEngineOffEntry() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected InsertTowMotorEngineOffEntry(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            InsertTowMotorEngineOffEntry cln = ((InsertTowMotorEngineOffEntry)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        internal void InitVars(bool initTable) {
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitClass() {
            this.DataSetName = "InsertTowMotorEngineOffEntry";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/InsertTowMotorEngineOffEntry.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            InsertTowMotorEngineOffEntry ds = new InsertTowMotorEngineOffEntry();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }
}
namespace TowMotorDLL.InsertTowMotorEngineOffEntryTableAdapters {
    
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class QueriesTableAdapter : global::System.ComponentModel.Component {
        
        private global::System.Data.IDbCommand[] _commandCollection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        protected global::System.Data.IDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.IDbCommand[1];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Connection = new global::System.Data.SqlClient.SqlConnection(global::TowMotorDLL.Properties.Settings.Default.whsetracConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandText = "dbo.InsertTowMotorEngineOff";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@InspectionID", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TransmissionFluidLevel", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@EngineAirCleaner", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FuelSedimentor", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RadiatorCoolant", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OperatorsManual", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@InformationPlate", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SeatBelt", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@HoodLatch", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@BrakeFluid", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@OverheadGuard", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FingerGuards", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ParkingBreak", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@SteeringOperation", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@DriveControl", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@TiltControl", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Cab", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@FuelLevel", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Temperature", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@instrumentMonitors", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int InsertTowMotorEngineOff(
                    global::System.Nullable<int> InspectionID, 
                    global::System.Nullable<bool> TransmissionFluidLevel, 
                    global::System.Nullable<bool> EngineAirCleaner, 
                    global::System.Nullable<bool> FuelSedimentor, 
                    global::System.Nullable<bool> RadiatorCoolant, 
                    global::System.Nullable<bool> OperatorsManual, 
                    global::System.Nullable<bool> InformationPlate, 
                    global::System.Nullable<bool> SeatBelt, 
                    global::System.Nullable<bool> HoodLatch, 
                    global::System.Nullable<bool> BrakeFluid, 
                    global::System.Nullable<bool> OverheadGuard, 
                    global::System.Nullable<bool> FingerGuards, 
                    global::System.Nullable<bool> ParkingBreak, 
                    global::System.Nullable<bool> SteeringOperation, 
                    global::System.Nullable<bool> DriveControl, 
                    global::System.Nullable<bool> TiltControl, 
                    global::System.Nullable<bool> Cab, 
                    global::System.Nullable<bool> FuelLevel, 
                    global::System.Nullable<bool> Temperature, 
                    global::System.Nullable<bool> instrumentMonitors) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[0]));
            if ((InspectionID.HasValue == true)) {
                command.Parameters[1].Value = ((int)(InspectionID.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((TransmissionFluidLevel.HasValue == true)) {
                command.Parameters[2].Value = ((bool)(TransmissionFluidLevel.Value));
            }
            else {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((EngineAirCleaner.HasValue == true)) {
                command.Parameters[3].Value = ((bool)(EngineAirCleaner.Value));
            }
            else {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((FuelSedimentor.HasValue == true)) {
                command.Parameters[4].Value = ((bool)(FuelSedimentor.Value));
            }
            else {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((RadiatorCoolant.HasValue == true)) {
                command.Parameters[5].Value = ((bool)(RadiatorCoolant.Value));
            }
            else {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((OperatorsManual.HasValue == true)) {
                command.Parameters[6].Value = ((bool)(OperatorsManual.Value));
            }
            else {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((InformationPlate.HasValue == true)) {
                command.Parameters[7].Value = ((bool)(InformationPlate.Value));
            }
            else {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((SeatBelt.HasValue == true)) {
                command.Parameters[8].Value = ((bool)(SeatBelt.Value));
            }
            else {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((HoodLatch.HasValue == true)) {
                command.Parameters[9].Value = ((bool)(HoodLatch.Value));
            }
            else {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((BrakeFluid.HasValue == true)) {
                command.Parameters[10].Value = ((bool)(BrakeFluid.Value));
            }
            else {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((OverheadGuard.HasValue == true)) {
                command.Parameters[11].Value = ((bool)(OverheadGuard.Value));
            }
            else {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((FingerGuards.HasValue == true)) {
                command.Parameters[12].Value = ((bool)(FingerGuards.Value));
            }
            else {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((ParkingBreak.HasValue == true)) {
                command.Parameters[13].Value = ((bool)(ParkingBreak.Value));
            }
            else {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((SteeringOperation.HasValue == true)) {
                command.Parameters[14].Value = ((bool)(SteeringOperation.Value));
            }
            else {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((DriveControl.HasValue == true)) {
                command.Parameters[15].Value = ((bool)(DriveControl.Value));
            }
            else {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((TiltControl.HasValue == true)) {
                command.Parameters[16].Value = ((bool)(TiltControl.Value));
            }
            else {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Cab.HasValue == true)) {
                command.Parameters[17].Value = ((bool)(Cab.Value));
            }
            else {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((FuelLevel.HasValue == true)) {
                command.Parameters[18].Value = ((bool)(FuelLevel.Value));
            }
            else {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Temperature.HasValue == true)) {
                command.Parameters[19].Value = ((bool)(Temperature.Value));
            }
            else {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            if ((instrumentMonitors.HasValue == true)) {
                command.Parameters[20].Value = ((bool)(instrumentMonitors.Value));
            }
            else {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
}

#pragma warning restore 1591