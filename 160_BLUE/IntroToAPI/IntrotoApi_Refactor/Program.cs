SWAPI_Service _service = new SWAPI_Service();

Person luke = await _service.GetPersonAsync("https://swapi.dev/api/people/1");
System.Console.WriteLine(luke.Name);

Vehicles vehicle = await _service.GetVehicleAsync("https://swapi.dev/api/vehivles/14");
System.Console.WriteLine(vehicle.Name);