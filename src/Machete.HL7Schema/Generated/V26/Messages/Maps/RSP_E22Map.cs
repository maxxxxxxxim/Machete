// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_E22 (MessageMap) - 
    /// </summary>
    public class RSP_E22Map :
        HL7TemplateMap<RSP_E22>
    {
        public RSP_E22Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segments(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segments(x => x.ERR, 4);
            Segment(x => x.QAK, 5, x => x.Required = true);
            Segment(x => x.QPD, 6, x => x.Required = true);
            Group(x => x.AuthorizationInfo, 7);
        }
    }
}