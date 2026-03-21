var builder = new SqlQueryBuilder();
builder.SetTable("Empleados");
builder.AddColumn("Nombre");
builder.AddColumn("Cargo");
builder.AddWhere("Salario > 5000");
builder.AddWhere("Activo = 1");

SqlQuery query = builder.Build();
Console.Write(query.CommandText);
