## Controlador `CarbonEmissionController`

Este controlador maneja las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para la entidad `CarbonEmission`. A continuación, se detalla cada acción disponible en el controlador:

### Acciones del Controlador

1. **Obtener Todos los Registros**

   - **Método HTTP**: `GET`
   - **Ruta**: `api/CarbonEmission/GetAll`
   - **Descripción**: Recupera todos los registros de emisiones de carbono.
   - **Respuesta Exitosa**: `200 OK` con un objeto `IEnumerable<CarbonEmissionModel>`.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpGet(nameof(GetAll))]
   public async Task<IActionResult> GetAll()
   {
       return Ok(await _Manager.GetAll());
   }
   ```

2. **Obtener Registro por ID**

   - **Método HTTP**: `GET`
   - **Ruta**: `api/CarbonEmission/GetById`
   - **Descripción**: Recupera un registro de emisión de carbono específico por su ID.
   - **Parámetros**: `Id` (int) - ID del registro.
   - **Respuesta Exitosa**: `200 OK` con un objeto `CarbonEmissionModel`.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpGet(nameof(GetById))]
   public async Task<IActionResult> GetById(int Id)
   {
       return Ok(await _Manager.GetById(Id));
   }
   ```

3. **Obtener Registros por ID de Compañía**

   - **Método HTTP**: `GET`
   - **Ruta**: `api/CarbonEmission/GetByCompanyId`
   - **Descripción**: Recupera registros de emisión de carbono por el ID de la compañía.
   - **Parámetros**: `CompanyId` (int) - ID de la compañía.
   - **Respuesta Exitosa**: `200 OK` con un objeto `CarbonEmissionModel`.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpGet(nameof(GetByCompanyId))]
   public async Task<IActionResult> GetByCompanyId(int CompanyId)
   {
       return Ok(await _Manager.GetByCompanyId(CompanyId));
   }
   ```

4. **Crear un Nuevo Registro**

   - **Método HTTP**: `POST`
   - **Ruta**: `api/CarbonEmission/Create`
   - **Descripción**: Crea un nuevo registro de emisión de carbono.
   - **Parámetros**: `model` (CarbonEmissionModel) - Datos del nuevo registro.
   - **Respuesta Exitosa**: `200 OK` con un entero indicando el resultado de la operación.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpPost(nameof(Create))]
   public async Task<IActionResult> Create([FromBody] CarbonEmissionModel model)
   {
       return Ok(await _Manager.CreateCarbonEmission(model));
   }
   ```

5. **Actualizar un Registro Existente**

   - **Método HTTP**: `PUT`
   - **Ruta**: `api/CarbonEmission/Update`
   - **Descripción**: Actualiza un registro de emisión de carbono existente.
   - **Parámetros**: `model` (CarbonEmissionModel) - Datos actualizados del registro.
   - **Respuesta Exitosa**: `200 OK` con un booleano indicando si la operación fue exitosa.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpPut(nameof(Update))]
   public async Task<IActionResult> Update([FromBody] CarbonEmissionModel model)
   {
       return Ok(await _Manager.UpdateCarbonEmission(model));
   }
   ```

6. **Eliminar un Registro (Soft Delete)**

   - **Método HTTP**: `DELETE`
   - **Ruta**: `api/CarbonEmission/SoftDelete`
   - **Descripción**: Elimina un registro de emisión de carbono de manera lógica (soft delete).
   - **Parámetros**: `Id` (int) - ID del registro a eliminar.
   - **Respuesta Exitosa**: `200 OK` con un booleano indicando si la operación fue exitosa.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpDelete(nameof(SoftDelete))]
   public async Task<IActionResult> SoftDelete(int Id)
   {
       return Ok(await _Manager.SoftDeleteCarbonEmission(Id));
   }
   ```

7. **Eliminar un Registro (Hard Delete)**

   - **Método HTTP**: `DELETE`
   - **Ruta**: `api/CarbonEmission/Delete`
   - **Descripción**: Elimina un registro de emisión de carbono de manera permanente (hard delete).
   - **Parámetros**: `Id` (int) - ID del registro a eliminar.
   - **Respuesta Exitosa**: `200 OK` con un booleano indicando si la operación fue exitosa.
   - **Respuesta de Error**: `500 Internal Server Error` con un mensaje de error.

   ```csharp
   [HttpDelete(nameof(Delete))]
   public async Task<IActionResult> Delete(int Id)
   {
       return Ok(await _Manager.HardDeleteCarbonEmission(Id));
   }
   ```

---
