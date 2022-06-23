using Amazon.DynamoDBv2.DataModel;
using AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    [DynamoDBTable("Dynamic-Assessment")]
    public class AssessmentInfoDto
    {
        [DynamoDBHashKey]
        public string partition_key { get; set; }
        [DynamoDBRangeKey("sort_key")]
        public string sort_key { get; set; }
        [DynamoDBProperty("version")]
        public string? version { get; set; }
        [DynamoDBProperty("grade_level")]
        public string? grade_level { get; set; }
        [DynamoDBProperty("created")]
        public string? created { get; set; }
        [DynamoDBProperty("updated")]
        public string? updated { get; set; }
        [DynamoDBProperty("assessment_containers")]
        public List<string> assessment_containers { get; set; }
        [DynamoDBProperty("assessment_id")]
        public string? assessment_id { get; set; }
        [DynamoDBProperty("item_id")]
        public string? item_id { get; set; }
        [DynamoDBProperty("attempt_number")]
        public string? attempt_number { get; set; }
        [DynamoDBProperty("assessment_template")]
        public string? assessment_template { get; set; }
         [DynamoDBProperty("delivery_configurations")]
        public DeliveryConfigurationDto delivery_configurations { get; set; }
        [DynamoDBProperty("attempts")]
        public string? attempts { get; set; }
        [DynamoDBProperty("ctk_take_id")]
        public string? ctk_take_id { get; set; }
        [DynamoDBProperty("product_information")]
        public ProductInformationDto product_information { get; set; }
        [DynamoDBProperty("name")]
        public string? name { get; set; }
        [DynamoDBProperty("description")]
        public string? description { get; set; }
        [DynamoDBProperty("item_selection_criteria")]
        public ItemSelectionCriteriaDto itemSelectionCriteria{get; set;}
        [DynamoDBProperty("item_randamization")]
        public ItemRandamizationDto itemRandamization{get; set;}
         [DynamoDBProperty("asessment_parts")]
        public AsessmentPartsDto asessment_parts { get; set; }
        [DynamoDBProperty("default_settings")]
        public DefaultSettingsDto defaultSettings{get; set;}
        [DynamoDBProperty("assessment_container_id")]
        public string? assessment_container_id { get; set; }
         [DynamoDBProperty("assessment_configurations")]
        public AssessmentConfigurationsDto assessment_configurations { get; set; }
        [DynamoDBProperty("items")]
        public List<ItemsInfoDto> items { get; set; }
        [DynamoDBProperty("is_item_seen")]
        public string? is_item_seen { get; set; }
    }
}