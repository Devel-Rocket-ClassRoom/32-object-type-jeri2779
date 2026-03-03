# GameItem

게임 아이템 시스템을 구현하세요. 기본 `Item` 클래스와 이를 상속받는 `Weapon`, 
`Potion` 클래스를 만들고, 
`ToString()` 메서드를 재정의하여 각 아이템의 정보를 출력합니다.

### 요구사항

1. `Item` 기본 클래스:
   - `Name` (string): 아이템 이름
   - `Price` (int): 아이템 가격
   - `ToString()` 재정의: 아이템 정보 출력

2. `Weapon` 클래스 (Item 상속):
   - `Damage` (int): 공격력
   - `ToString()` 재정의: 무기 정보 출력

3. `Potion` 클래스 (Item 상속):
   - `HealAmount` (int): 회복량
   - `ToString()` 재정의: 포션 정보 출력

4. `Inventory` 클래스:
   - `object[]` 배열로 최대 10개의 아이템 저장
   - `AddItem(object item)`: 아이템 추가
   - `ShowInventory()`: 모든 아이템 정보와 타입 출력

5. 테스트:
   - 무기와 포션을 생성하여 인벤토리에 추가
   - 인벤토리 내용을 출력하고 각 아이템의 타입 확인
   - `typeof()`와 `GetType()` 비교 결과 출력

## 예상 실행 결과

```
=== 인벤토리 시스템 테스트 ===

[인벤토리 내용]
슬롯 1: Weapon { Name = 불꽃 검, Price = 500, Damage = 25 } [Weapon]
슬롯 2: Weapon { Name = 얼음 활, Price = 450, Damage = 20 } [Weapon]
슬롯 3: Potion { Name = 체력 물약, Price = 50, HealAmount = 100 } [Potion]
슬롯 4: Potion { Name = 마나 물약, Price = 80, HealAmount = 50 } [Potion]

=== 타입 확인 테스트 ===
sword의 타입: Weapon
sword.GetType() == typeof(Weapon): True
sword.GetType() == typeof(Item): False
sword is Item: True
```
