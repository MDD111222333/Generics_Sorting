# C_Sharp_Generics_Sorting

## C#_Generics_Sorting

### Задание «Контрольная точка №34 — IComparer<T>, IComparable<T>, сортировка»

Вариант 1. Товары
1. `Product : IComparable<Product>`, естественный порядок — по цене.
2. `class NameComparer : IComparer<Product>` — порядок по названию.
3. `List<Product>` минимум из 4 элементов.
4. Продемонстрируйте `Sort()` (по цене) и `Sort(new NameComparer())` (по названию) на одном и том же списке, выведя результат после каждой сортировки.
5. Дополнительно продемонстрируйте третий порядок (например, по длине названия) через лямбду и `Comparison<Product>`.

---

### Результаты и проверочные ключи:
<img width="1479" height="261" alt="изображение" src="https://github.com/user-attachments/assets/b3a0ab55-ba54-4e6f-a80b-cc96d0d441ed" />

### Результат работы программы:
<img width="1596" height="1104" alt="изображение" src="https://github.com/user-attachments/assets/917d0148-a864-40fb-b1ff-ab6c3012bdf5" />
