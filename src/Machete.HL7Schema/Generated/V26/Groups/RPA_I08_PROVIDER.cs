// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RPA_I08_PROVIDER (Group) - 
    /// </summary>
    public interface RPA_I08_PROVIDER :
        HL7Template
    {
        /// <summary>
        /// PRD
        /// </summary>
        Segment<PRD> PRD { get; }

        /// <summary>
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }
    }
}