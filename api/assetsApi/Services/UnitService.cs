using Microsoft.AspNetCore.Mvc;
using System;

public class UnitServices
{
	private readonly ApplicationDbCobntext _context;
	public UnitServices(ApplicationDbCobntext context)
	{
	    _context = context;
	}


	//יצירת יחידה 
	public async Task Create(Unit unit)
	{
	    await _context.Units.Add(unit);
		await _context.SaveChanges();
	}


	//רשימת כל היחידות
    public async Task<List<Unit>> GetAll()
    {
		List<Unit> UnitList = await _context.Units.ToList();
        return UnitList;
    }


    //חיפוש יחידה לפי מזהה
    public async Task<Unit> GetById(Guid id)
    {
		Unit unit = await _context.Units.FirstOrDefault(x => x.Id == id);  
        return unit;
    }


    //עדכון שם יחידה ע"י קבלת אובייקט של יחידה
    public async Task Update(Unit unit)
    {
        Unit ExistUnit = await _context.Units.FirstOrDefault(x => x.Id == unit.Id);
        ExistUnit.Name = unit.Name;
        await _context.SaveChanges();
    }

    //עדכון שם יחידה ע"י קבלת שם ומזהה
    public async Task Update(string unitName, Guid id)
    {
        Unit ExistUnit = await _context.Units.FirstOrDefault(x => x.Id == Id);
        ExistUnit.Name = unitName;
        await _context.SaveChanges();
    }
}
