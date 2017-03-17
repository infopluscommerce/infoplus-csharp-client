using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class VendorComplianceSurvey :  IEquatable<VendorComplianceSurvey>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorComplianceSurvey" /> class.
        /// Initializes a new instance of the <see cref="VendorComplianceSurvey" />class.
        /// </summary>
        /// <param name="WorksheetId">WorksheetId (required).</param>
        /// <param name="SurveyQuestions">SurveyQuestions.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public VendorComplianceSurvey(int? WorksheetId = null, string SurveyQuestions = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "WorksheetId" is required (not null)
            if (WorksheetId == null)
            {
                throw new InvalidDataException("WorksheetId is a required property for VendorComplianceSurvey and cannot be null");
            }
            else
            {
                this.WorksheetId = WorksheetId;
            }
            this.SurveyQuestions = SurveyQuestions;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WorksheetId
        /// </summary>
        [DataMember(Name="worksheetId", EmitDefaultValue=false)]
        public int? WorksheetId { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets SurveyQuestions
        /// </summary>
        [DataMember(Name="surveyQuestions", EmitDefaultValue=false)]
        public string SurveyQuestions { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorComplianceSurvey {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WorksheetId: ").Append(WorksheetId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  SurveyQuestions: ").Append(SurveyQuestions).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VendorComplianceSurvey);
        }

        /// <summary>
        /// Returns true if VendorComplianceSurvey instances are equal
        /// </summary>
        /// <param name="other">Instance of VendorComplianceSurvey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorComplianceSurvey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.WorksheetId == other.WorksheetId ||
                    this.WorksheetId != null &&
                    this.WorksheetId.Equals(other.WorksheetId)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.SurveyQuestions == other.SurveyQuestions ||
                    this.SurveyQuestions != null &&
                    this.SurveyQuestions.Equals(other.SurveyQuestions)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.WorksheetId != null)
                    hash = hash * 59 + this.WorksheetId.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.SurveyQuestions != null)
                    hash = hash * 59 + this.SurveyQuestions.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
