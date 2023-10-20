string[] matrix = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

foreach(string product in matrix) {
    if (product.StartsWith("B")) {
        Console.WriteLine(product);
    }
}