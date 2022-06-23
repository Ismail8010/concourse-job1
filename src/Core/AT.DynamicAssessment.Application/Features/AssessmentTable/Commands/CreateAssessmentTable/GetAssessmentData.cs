using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class GetAssessmentData
    {
        public static List<AssessmentInfoDto> GetAssessmentInfoStaticValues()
        {
            List<string> Container = new List<string>();
            Container.Add("501");
            List<string> Container2 = new List<string>();
            Container.Add("502");
            Container.Add("503");
            Container.Add("504");
            Container.Add("505");

            List<ItemsInfoDto> itemsInfoDtos = GetStaticData.GetItemInfoStaticValues();
            List<AssessmentInfoDto> assessmentInfo = new List<AssessmentInfoDto>()
            {
           new AssessmentInfoDto()
           {
            partition_key = "1",
            sort_key = "assessment#assessment_id#201#ctk_take_id#301",
            version = "1.0",
            created = "4/25/2022",
            assessment_containers = Container,
            assessment_id = "201",
            assessment_template = "QUIZ",
            ctk_take_id = "301",
            items = itemsInfoDtos,
          },
        new AssessmentInfoDto()
           {
            partition_key = "1",
            sort_key = "assessment#assessment_id#201#ctk_take_id#303",
            version = "1.0",
            created = "6/17/2022",
            assessment_containers = Container,
            assessment_id = "201",
            assessment_template = "QUIZ",
            ctk_take_id = "303",
            items = itemsInfoDtos,
         },
        new AssessmentInfoDto()
           {
            partition_key = "1",
            sort_key = "item#assessment_id#201#ctk_take_id#301#item_id#1001",
            version = "1.0",
            created = "6/17/2022",
            assessment_id = "201",
            ctk_take_id = "301",
            item_id = "1001",
            assessment_container_id = "501",
            is_item_seen = "True"
        },
        new AssessmentInfoDto()
           {
            partition_key = "1",
            sort_key = "item#assessment_id#201#ctk_take_id#301#item_id#1002",
            version = "1.0",
            created = "6/17/2022",
            assessment_id = "201",
            ctk_take_id = "301",
            assessment_container_id = "501",
            item_id = "1002",
            is_item_seen = "True"
        },
        new AssessmentInfoDto()
           {
            partition_key = "2",
            sort_key = "assessment#assessment_id#202#ctk_take_id#302",
            version = "1.0",
            created = "6/17/2022",
            assessment_containers = Container2,
            assessment_id = "202",
            assessment_template = "TEST",
            ctk_take_id = "302",
            items = itemsInfoDtos,
        },
        new AssessmentInfoDto()
           {
            partition_key = "2",
            sort_key = "assessment#assessment_id#201#ctk_take_id#305",
            version = "1.0",
            created = "6/17/2022",
            assessment_containers = Container,
            assessment_id = "202",
            assessment_template = "QUIZ",
            ctk_take_id = "305",
            items = itemsInfoDtos,
        },
         new AssessmentInfoDto()
           {
            partition_key = "2",
            sort_key = "item#assessment_id#201#ctk_take_id#304#item_id#1021",
            version = "1.0",
            created = "6/17/2022",
            assessment_id = "201",
            item_id = "1021",
            ctk_take_id = "304",
            assessment_container_id = "501",
            is_item_seen = "True"
        },
        new AssessmentInfoDto()
           {
            partition_key = "TEST",
            sort_key = "1.0",
            name = "Test Assessment",
            description = "Test assessment configuration",
            itemSelectionCriteria = GetStaticData.GetItemSelectionValues(),
            itemRandamization = GetStaticData.GetItemRandamizationValues(),
            defaultSettings = GetStaticData.GetDefaultSettingsValues()
           },
           new AssessmentInfoDto()
           {
            partition_key = "QUIZ",
            sort_key = "1.0",
            name = "QUIZ Assessment",
            description = "QUIZ assessment configuration",
            itemSelectionCriteria = GetStaticData.GetItemSelectionValues(),
            itemRandamization = GetStaticData.GetItemRandamizationValues(),
            defaultSettings = GetStaticData.GetDefaultSettingsValues()
           },
    };
            return assessmentInfo;
        }
    }
}