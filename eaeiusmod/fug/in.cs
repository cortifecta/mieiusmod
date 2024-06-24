T Deserialize<T>(string fileName) {
    Type type = typeof(T);
    var obj = Activator.CreateInstance(type);
    // Custom deserialization logic here
    return (T)obj;
}
