// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{

    /// <summary>
    /// Defines values for InputFormat.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputFormat
    {
        [System.Runtime.Serialization.EnumMember(Value = "org.apache.hadoop.mapred.SequenceFileInputFormat")]
        OrgapachehadoopmapredSequenceFileInputFormat,
        [System.Runtime.Serialization.EnumMember(Value = "org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat")]
        OrgapachehadoophiveqlioparquetMapredParquetInputFormat,
        [System.Runtime.Serialization.EnumMember(Value = "org.apache.hadoop.mapred.TextInputFormat")]
        OrgapachehadoopmapredTextInputFormat
    }
}
