using System;

class Product {
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category) {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program {
    static int LinearSearch(Product[] products, string name) {
        for (int i = 0; i < products.Length; i++) {
            if (products[i].ProductName == name) return i;
        }
        return -1;
    }

    static int BinarySearch(Product[] products, string name) {
        int left = 0, right = products.Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            int cmp = string.Compare(products[mid].ProductName, name);
            if (cmp == 0) return mid;
            if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    static void Main() {
        Product[] products = {
            new Product(1, "Mobile", "Electronics"),
            new Product(2, "Laptop", "Electronics"),
            new Product(3, "Watch", "Accessories")
        };

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName)); // Binary search needs sorted array

        int indexLinear = LinearSearch(products, "Laptop");
        int indexBinary = BinarySearch(products, "Laptop");

        Console.WriteLine("Linear Search: 'Laptop' found at index " + indexLinear);
        Console.WriteLine("Binary Search: 'Laptop' found at index " + indexBinary);
    }
}
