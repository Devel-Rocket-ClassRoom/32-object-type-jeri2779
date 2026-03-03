using System;
using System.Runtime.InteropServices;

Console.WriteLine("=== 인벤토리 시스템 테스트 ===");
Console.WriteLine();
Console.WriteLine("[인벤토리 내용]");
Inventory inventory = new Inventory();//인벤토리 객체 생성
Weapon sword = new Weapon { Name = "불꽃 검", Price = 500, Damage = 25 };//무기 생성
Weapon bow = new Weapon { Name = "얼음 활", Price = 450, Damage = 20 };
Potion healthPotion = new Potion { Name = "체력 물약", Price = 50, HealAmount = 100 };
Potion manaPotion = new Potion { Name = "마나 물약", Price = 80, HealAmount = 50 };

inventory.AddItem(sword);
inventory.AddItem(bow);
inventory.AddItem(healthPotion);
inventory.AddItem(manaPotion);
inventory.ShowInventory();

Console.WriteLine("\n=== 타입 확인 테스트 ===");
Console.WriteLine($"sword의 타입: {sword.GetType().Name}");
Console.WriteLine($"sword.GetType() == typeof(Weapon): {sword.GetType() == typeof(Weapon)}");
Console.WriteLine($"sword.GetType() == typeof(Item): {sword.GetType() == typeof(Item)}");
Console.WriteLine($"sword is Item: {sword is Item}");



class Item
{
    public string Name;
    public int Price;
    //`ToString()` 재정의: 아이템 정보 출력
    public override string ToString()
    {
        return $"Item: {Name}, Price: {Price}";
    }

}
class Weapon : Item
{
    public int Damage;
    public override string ToString()
    {
        return $"{{ Name = {Name}, Price = {Price}, Damage = {Damage} }}";
    }
}

class Potion : Item
{
    public int HealAmount;
    public override string ToString()
    {
        return $"{{ Name ={Name}, Price = {Price}, HealAmount = {HealAmount}}}";
    }
}

 class Inventory
{
    //`object[]` 배열로 최대 10개의 아이템 저장
    public object[] items = new object[10];
    private int index = 0; // 아이템 개수 카운트
    //`AddItem(object item)` 메서드: 아이템 추가
    //인덱스 0번칸부터 순차 저장 저장시 index++ 처리
    public void AddItem(object item)
    {
        if(index < items.Length)
        {
            items[index++] = item;
        }
        else
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
            return;
        }

    }

    //ShowInventory()`: 모든 아이템 정보와 타입 출력
    public void ShowInventory()
    {
        Console.WriteLine("=== 인벤토리 ===");
        for(int i = 0; i < index; i++)
        {
            //슬롯 1: Weapon { Name = 불꽃 검, Price = 500, Damage = 25 } [Weapon]
            Console.WriteLine($"슬롯: {i + 1} {items[i].GetType().Name} {items[i]} [{items[i].GetType().Name}]");
        }
    }
    //요구 출력문은 슬롯 1: Weapon { Name = 불꽃 검, Price = 500, Damage = 25 } [Weapon]
    //그러나 실제 출력문은  슬롯:1 Weapon Name = Weapon: 불꽃 검, Price: 500, Damage: 25 [Weapon]
    //Name = 과  불꽃 검 사이에 Weapon이 붙어서 나온다
    //해당 원인파악이 필요함
    //임시조치로 Tostring의 return값에서 Weapon과 Item 제거 하여 요구 출력문에 맟춤
    //요구 사항중에 Tostring에 대한 상세 요구는 없었기에 큰 문제가 되지 않을것으로 판단함
    //추가 수정 부분
    //Tostring을 {{ Name = {Name}, Price = {Price}, Damage = {Damage} }} 로 변경함
    //Name = 을 별도로 출력하려 했던게 문제였음. Name 부분도 Tostring에서만 출력하도록 했어야 했음.



}