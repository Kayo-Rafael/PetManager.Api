using Pet.Comunnication.Responses;

namespace Pet.Application.UseCases.Pets.GetAll;

public class GetAllPetUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson{
                    Id = 1,
                    Name = "Duque",
                    Type = Comunnication.Enums.PetType.Dog
                }
            }
        };
    }
}
