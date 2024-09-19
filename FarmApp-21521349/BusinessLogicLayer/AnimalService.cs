using System.Collections.Generic;
using FarmApp.DataAccessLayer;
using FarmApp_21521349.Models;

namespace FarmApp.BusinessLogicLayer
{
    public class AnimalService
    {
        private AnimalRepository _animalRepository;

        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }

        // Thêm gia súc
        public void AddAnimals(Animal animal)
        {
            _animalRepository.AddAnimal(animal);
        }

        // Lấy danh sách gia súc
        public List<Animal> GetAnimals()
        {
            return _animalRepository.GetAllAnimals();
        }

        // Xử lý logic cho sinh con và cho sữa
        public void ProcessMilkAndBirths()
        {
            List<Animal> animals = _animalRepository.GetAllAnimals();

            foreach (var animal in animals)
            {
                // Tính số lít sữa và số con sinh
                int totalMilk = animal.MilkProduction();
                int totalBirths = animal.Birth();

                // Cập nhật vào CSDL
                _animalRepository.UpdateAnimalStats(animal.Type, totalMilk, totalBirths);
            }
        }
    }
}
