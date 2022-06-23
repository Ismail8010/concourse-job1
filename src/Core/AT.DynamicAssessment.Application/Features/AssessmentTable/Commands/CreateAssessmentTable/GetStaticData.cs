using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable
{
    public class GetStaticData
    {
        public static List<ItemsInfoDto> GetItemInfoStaticValues()
        {
            List<string> Container = new List<string>();
            Container.Add("501");
            List<ItemsInfoDto> itemsInfoDtos = new List<ItemsInfoDto>()
            {
            new ItemsInfoDto { Id = "1001",content_id = "7e1a43f1-6db1-460c-b2d1-61ddcbc11ab1", Version = "1.0"},
            new ItemsInfoDto { Id = "1002",content_id = "7e1a43f1-6db1-460c-b2d2-61ddcbc11ab1", Version = "1.0" },
            new ItemsInfoDto { Id = "1003",content_id= "7e1a43f1-6db1-460c-b2d2-61ddcbc11ab1", Version = "1.0" },
            new ItemsInfoDto { Id = "1004",content_id = "7e1a43f1-6db1-460c-b2d2-61ddcbc11ab1", Version = "1.0" },
            new ItemsInfoDto { Id = "1005",content_id= "7e1a43f1-6db1-460c-b2d2-61ddcbc11ab1", Version = "1.0" }
    };
            return itemsInfoDtos;
        }
         public static ItemSelectionCriteriaDto GetItemSelectionValues()
        {
            ItemSelectionCriteriaDto itemSelectionCriteria = new ItemSelectionCriteriaDto();
            itemSelectionCriteria.numberOfItems = "25";
            itemSelectionCriteria.minumunNumberOfItems = "10";
            List<string> selectItemwithTag = new List<string>();
            selectItemwithTag.Add("TEST");
            itemSelectionCriteria.selectItemsWithTags = selectItemwithTag;
            List<string> selectItemsWithTagsFallback = new List<string>();
            selectItemsWithTagsFallback.Add("QUIZ");
            selectItemsWithTagsFallback.Add("none");
            itemSelectionCriteria.selectItemsWithTagsFallback = selectItemsWithTagsFallback;
            itemSelectionCriteria.preferedItemNotseen = "Yes";
            itemSelectionCriteria.preferedSameItemFamily = "Yes";
            return itemSelectionCriteria;
        }
        public static ItemRandamizationDto GetItemRandamizationValues()
        {
            ItemRandamizationDto itemRandamizationDto = new ItemRandamizationDto();
            itemRandamizationDto.randomization = "Yes";
            itemRandamizationDto.keepItemFamiliesTogether = "Yes";
            return itemRandamizationDto;
        }
        public static DefaultSettingsDto GetDefaultSettingsValues()
        {
            DefaultSettingsDto defaultSettings = new DefaultSettingsDto();
            defaultSettings.timelimit = "60";
            defaultSettings.freeNavigation = "Yes";
            defaultSettings.canSubmitWithoutAnsweringAll = "Yes";
            defaultSettings.canSaveAndExit = "No";
            defaultSettings.HideViewedQuestions = "Yes";
            defaultSettings.attempts = "5";
            defaultSettings.passingThreashold = "70";
            defaultSettings.studentReview = "questionsAndCorrectAnswers";
            return defaultSettings;
        }
        
    }
}