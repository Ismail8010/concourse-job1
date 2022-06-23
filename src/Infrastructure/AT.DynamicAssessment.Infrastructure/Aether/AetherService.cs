using AT.DynamicAssessment.Application.Contracts.Infrastructure;
using AT.DynamicAssessment.Application.Model.Aether;
using Model = AT.DynamicAssessment.Application.Model.Aether;

namespace AT.DynamicAssessment.Infrastructure.Aether;

public class AetherService : IAetherServicee<Model.Content>
{
    public async Task<List<Content>> GetQuestionItemsByContent()
    {
        

        List<QuestionItem> questionItem = new List<QuestionItem>
        {
            new QuestionItem { ContentId = "948f7f6b-28c2-464b-a112-4e59c2c99c4a", Id = 28435, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "95b8cc4b-7b07-4a5c-8b7c-c01bf0b6f36d", Id = 28436, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "5e471967-580b-478d-bc5d-0f37b19d1e04", Id = 28437, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "689a4d59-da6f-4e55-a01a-507c05359972", Id = 28438, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "2d89d52b-18cf-446c-9b87-39753d0dc036", Id = 28439, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "d7813057-f5b0-4767-8b3c-da1726144c24", Id = 28440, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "2b4a1560-afce-4b55-989d-32c9216cc4f5", Id = 28441, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "b52b7f4e-6d5d-4513-8207-80704cba2c2c", Id = 28442, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "2604d9dc-e9b1-4e49-afb4-4b0d4cf56eee", Id = 28443, Type="QuestionItem", Tag="exam"},
            new QuestionItem { ContentId = "523351b2-a8a9-44cd-a059-6f5f3e72bdc1", Id = 28444, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "cb083c18-5532-4d24-8135-ac41e0b7642b", Id = 28445, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "5af3f152-785f-40dd-b3a5-df3a6ab8c4fc", Id = 28446, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "7f7b7b50-7aff-42ed-aed1-f7b9f4b5654e", Id = 28447, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "f85b9ea5-6b2c-4a0b-91d7-c2878228329e", Id = 28448, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "b530d641-9b43-46f0-83f2-fb44a8325a1c", Id = 28449, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "ecdaf4e7-b23e-496b-93d6-069d0cbca1c7", Id = 28450, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "3f232949-d55f-43fa-9c9b-c240c47059c3", Id = 28451, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "417377a7-9594-4845-8335-b850d94eeb4a", Id = 28452, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "12b3c0c8-2fb1-4787-8968-113d0517fdb1", Id = 28453, Type="QuestionItem", Tag="exam"},
            new QuestionItem { ContentId = "b8034aef-7b76-48d1-8e63-73466f7665b9", Id = 28454, Type="QuestionItem", Tag="exam"},
            new QuestionItem { ContentId = "af19b1a7-18b7-487a-a885-4d97286d64b3", Id = 28455, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "a339bae1-816a-4175-baf0-1fe919af10ef", Id = 28456, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "a6a276ce-a8e3-44af-9e5e-c42c6741968c", Id = 28457, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "6ad70c52-c8f6-47e8-87f4-776cd201b629", Id = 28458, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "c676d70b-2fc6-4bb9-b2fb-8a9562b9ca07", Id = 28459, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "4e825565-7d18-4308-b0e8-f41fc84afa53", Id = 28460, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "c2b5b58f-7bd0-4fef-8076-225d30ccaf1f", Id = 28461, Type="QuestionItem", Tag="quiz"},

        };
         List<QuestionItem> questionItem1 = new List<QuestionItem>
        {
            new QuestionItem { ContentId = "c0d568ec-ca77-4267-976c-5df839404f4e", Id = 28340, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "a7698df0-6a0b-4259-bd00-275c5b1fcaa1", Id = 28341, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "a9ccd2e0-c068-4a1a-be97-c93f6ecc7e69", Id = 28342, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "4ce157ef-d5b7-4202-b153-b9ffff5333ef", Id = 28343, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "32f42a19-ab11-4b96-b503-fd13850cf0f9", Id = 28344, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "fda8d17d-ff67-4eb2-bad3-fe3565139640", Id = 28345, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "61be30f8-7371-49b6-9fd7-37c6fcbe035e", Id = 28346, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "c1fe867a-14ed-491e-8162-b53bcd39f635", Id = 28347, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "4a328c3b-e0d2-45c8-a949-d0f345d737e9", Id = 28348, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "752aecbd-c5cb-41f0-a075-493cfbfda797", Id = 28349, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "3ecbaaae-60c3-4b4a-a451-ca8ec0891789", Id = 28350, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "ff4341ec-e215-4fa3-afdb-d5304763061e", Id = 28351, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "ee4714aa-95a4-4d05-9414-a9c1ab5a9334", Id = 28352, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "afc58b0f-6baf-4610-8a7a-16b93a1d6998", Id = 28353, Type="QuestionItem", Tag="exam"},
            new QuestionItem { ContentId = "b536b6ea-0657-46af-ab74-c7062a70f5c1", Id = 28354, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "c2fff479-ed27-4959-8805-6bd90aa36b1a", Id = 28355, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "6a90f281-7e6b-43e4-8f4c-11688e198c66", Id = 28356, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "15fac1d0-66e2-441b-8f1e-5d82064bc0ae", Id = 28357, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "5c1a263a-6d7a-4152-b399-16ce99719965", Id = 28358, Type="QuestionItem", Tag="exam"},
            new QuestionItem { ContentId = "a7d75e90-d32c-4c3c-af86-53d598049312", Id = 28359, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "18d907f5-1031-4259-ba35-022bf3000141", Id = 28360, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "b6f0a4bc-4594-4b6f-bdbb-27b0c91ff4c0", Id = 28361, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "ac4be51b-13ce-4832-9381-52d28dbe5482", Id = 28362, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "f852ce63-1cb3-4a76-b2e6-f222d68d0b26", Id = 28363, Type="QuestionItem", Tag="quiz"},
            new QuestionItem { ContentId = "b98dcc62-afc8-4d27-aacb-518d44226e98", Id = 28364, Type="QuestionItem", Tag="test"},
            new QuestionItem { ContentId = "3ab99fa4-e565-410b-bd50-2ba2d25fea46", Id = 28365, Type="QuestionItem", Tag="quiz"},
            
        };

        List<Content> content = new List<Content>
        {
            new Content{ContentId = "5a05aa89-92ff-49bd-ad8a-e582f49cb375",Comment = "content migration",Id = 313,Title = null, questionItems=questionItem},
            new Content{ContentId = "712329da-dd2e-4679-b064-01bcb94d12fa",Comment = "content migration",Id = 311,Title = null, questionItems=questionItem1}

        };

        return content;
    }


}