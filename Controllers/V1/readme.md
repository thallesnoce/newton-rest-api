# Shows API — Student Instructions

## 1. Starting the API

Open a terminal in the project folder and run:

```bash
dotnet run
```

You should see output like:

```
Now listening on: http://localhost:5000
```

Keep this terminal open while working.

---

## 2. Exploring the API with Swagger

Swagger is a visual interface built into the API that lets you test endpoints directly from the browser.

### Steps

1. Open your browser and navigate to:
   ```
   http://localhost:5000/swagger
   ```

2. You will see a list of all available endpoints.

### Try GET all shows

1. Click on **GET** `/api/v1/shows`
2. Click **"Try it out"**
3. Click **"Execute"**
4. The response will appear below with the list of shows:

```json
[
  { "id": 1, "titulo": "Iron Maidem", "genero": "Rock", "cidade": "Belo Horizonte" },
  { "id": 2, "titulo": "Gueta Van Fleet", "genero": "Rock", "cidade": "São Paulo" },
  { "id": 3, "titulo": "Metálica", "genero": "Rock", "cidade": "Belo Horizonte" }
]
```

### Try GET a single show

1. Click on **GET** `/api/v1/shows/{id}`
2. Click **"Try it out"**
3. Enter `1` in the **id** field
4. Click **"Execute"**

---

## 3. Sending a POST request with Postman

Postman lets you send HTTP requests with a custom body (JSON).

### Steps

1. Open **Postman**
2. Click **"New"** → **"HTTP Request"**
3. Set the method to **POST**
4. Enter the URL:
   ```
   http://localhost:5000/api/v1/shows
   ```
5. Go to the **Body** tab
6. Select **raw** and choose **JSON** from the dropdown on the right
7. Paste the following JSON in the text area:

```json
{
  "titulo": "AC/DC",
  "genero": "Rock",
  "cidade": "Rio de Janeiro"
}
```

> **Note:** Do not include `"id"` — the API assigns it automatically.

8. Click **Send**

### Expected response

**Status:** `201 Created`

```json
{
  "id": 4,
  "titulo": "AC/DC",
  "genero": "Rock",
  "cidade": "Rio de Janeiro"
}
```

9. Now go back to Swagger and run **GET** `/api/v1/shows` again — you should see the new show in the list.

---

## 4. Quick Reference — All Endpoints

| Method   | URL                      | Description          |
|----------|--------------------------|----------------------|
| GET      | /api/v1/shows            | Get all shows        |
| GET      | /api/v1/shows/{id}       | Get a show by ID     |
| POST     | /api/v1/shows            | Create a new show    |
| PUT      | /api/v1/shows/{id}       | Update a show        |
| DELETE   | /api/v1/shows/{id}       | Delete a show        |

---

## 5. Show Object Structure

```json
{
  "titulo": "string",
  "genero": "string",
  "cidade": "string"
}
```
