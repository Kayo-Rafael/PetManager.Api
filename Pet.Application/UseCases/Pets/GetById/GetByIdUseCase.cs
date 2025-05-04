using Pet.Comunnication.Responses;

namespace Pet.Application.UseCases.Pets.GetById;

public class GetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Rex",
            Type = Comunnication.Enums.PetType.Cat,
            Birthday = new DateTime(year:2022, month: 01, day:05)
        };
    }
}
