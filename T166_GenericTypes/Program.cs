SomeMethod(new Pet(), new PetOwner());

void SomeMethod<TPet, TOwner>(TPet pet, TOwner owner)
	where TPet : Pet, IComparable<TPet>
	where TOwner : new()
{

}

public class Pet : IComparable<Pet>
{
	public int CompareTo(Pet? other)
	{
		throw new NotImplementedException();
	}
}

public class PetOwner { }
