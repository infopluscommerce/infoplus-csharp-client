/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v3.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Infoplus.Client.SwaggerDateConverter;

namespace Infoplus.Model
{
    /// <summary>
    /// JobRecipe
    /// </summary>
    [DataContract]
    public partial class JobRecipe :  IEquatable<JobRecipe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRecipe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobRecipe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRecipe" /> class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="LobId">LobId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="AssemblyInstructions">AssemblyInstructions.</param>
        /// <param name="Inputs">Inputs.</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="Steps">Steps.</param>
        /// <param name="FulfillmentPlanId">FulfillmentPlanId (required).</param>
        /// <param name="Layout">Layout (required).</param>
        /// <param name="TrackAssemblies">TrackAssemblies (required) (default to false).</param>
        /// <param name="TrackSteps">TrackSteps (required) (default to false).</param>
        /// <param name="CustomFields">CustomFields.</param>
        public JobRecipe(int? WarehouseId = default(int?), int? LobId = default(int?), string Name = default(string), string AssemblyInstructions = default(string), List<JobRecipeInput> Inputs = default(List<JobRecipeInput>), List<JobRecipeOutput> Outputs = default(List<JobRecipeOutput>), List<JobRecipeStep> Steps = default(List<JobRecipeStep>), int? FulfillmentPlanId = default(int?), string Layout = default(string), bool? TrackAssemblies = false, bool? TrackSteps = false, Dictionary<string, Object> CustomFields = default(Dictionary<string, Object>))
        {
            // to ensure "LobId" is required (not null)
            if (LobId == null)
            {
                throw new InvalidDataException("LobId is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.LobId = LobId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "FulfillmentPlanId" is required (not null)
            if (FulfillmentPlanId == null)
            {
                throw new InvalidDataException("FulfillmentPlanId is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.FulfillmentPlanId = FulfillmentPlanId;
            }
            // to ensure "Layout" is required (not null)
            if (Layout == null)
            {
                throw new InvalidDataException("Layout is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.Layout = Layout;
            }
            // to ensure "TrackAssemblies" is required (not null)
            if (TrackAssemblies == null)
            {
                throw new InvalidDataException("TrackAssemblies is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.TrackAssemblies = TrackAssemblies;
            }
            // to ensure "TrackSteps" is required (not null)
            if (TrackSteps == null)
            {
                throw new InvalidDataException("TrackSteps is a required property for JobRecipe and cannot be null");
            }
            else
            {
                this.TrackSteps = TrackSteps;
            }
            this.WarehouseId = WarehouseId;
            this.AssemblyInstructions = AssemblyInstructions;
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            this.Steps = Steps;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

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
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AssemblyInstructions
        /// </summary>
        [DataMember(Name="assemblyInstructions", EmitDefaultValue=false)]
        public string AssemblyInstructions { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<JobRecipeInput> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<JobRecipeOutput> Outputs { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<JobRecipeStep> Steps { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPlanId
        /// </summary>
        [DataMember(Name="fulfillmentPlanId", EmitDefaultValue=false)]
        public int? FulfillmentPlanId { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name="layout", EmitDefaultValue=false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or Sets TrackAssemblies
        /// </summary>
        [DataMember(Name="trackAssemblies", EmitDefaultValue=false)]
        public bool? TrackAssemblies { get; set; }

        /// <summary>
        /// Gets or Sets TrackSteps
        /// </summary>
        [DataMember(Name="trackSteps", EmitDefaultValue=false)]
        public bool? TrackSteps { get; set; }

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
            sb.Append("class JobRecipe {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssemblyInstructions: ").Append(AssemblyInstructions).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  FulfillmentPlanId: ").Append(FulfillmentPlanId).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  TrackAssemblies: ").Append(TrackAssemblies).Append("\n");
            sb.Append("  TrackSteps: ").Append(TrackSteps).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobRecipe);
        }

        /// <summary>
        /// Returns true if JobRecipe instances are equal
        /// </summary>
        /// <param name="input">Instance of JobRecipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobRecipe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.ModifyDate == input.ModifyDate ||
                    (this.ModifyDate != null &&
                    this.ModifyDate.Equals(input.ModifyDate))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.LobId == input.LobId ||
                    (this.LobId != null &&
                    this.LobId.Equals(input.LobId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AssemblyInstructions == input.AssemblyInstructions ||
                    (this.AssemblyInstructions != null &&
                    this.AssemblyInstructions.Equals(input.AssemblyInstructions))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.FulfillmentPlanId == input.FulfillmentPlanId ||
                    (this.FulfillmentPlanId != null &&
                    this.FulfillmentPlanId.Equals(input.FulfillmentPlanId))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.TrackAssemblies == input.TrackAssemblies ||
                    (this.TrackAssemblies != null &&
                    this.TrackAssemblies.Equals(input.TrackAssemblies))
                ) && 
                (
                    this.TrackSteps == input.TrackSteps ||
                    (this.TrackSteps != null &&
                    this.TrackSteps.Equals(input.TrackSteps))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.ModifyDate != null)
                    hashCode = hashCode * 59 + this.ModifyDate.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.LobId != null)
                    hashCode = hashCode * 59 + this.LobId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AssemblyInstructions != null)
                    hashCode = hashCode * 59 + this.AssemblyInstructions.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.FulfillmentPlanId != null)
                    hashCode = hashCode * 59 + this.FulfillmentPlanId.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.TrackAssemblies != null)
                    hashCode = hashCode * 59 + this.TrackAssemblies.GetHashCode();
                if (this.TrackSteps != null)
                    hashCode = hashCode * 59 + this.TrackSteps.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
