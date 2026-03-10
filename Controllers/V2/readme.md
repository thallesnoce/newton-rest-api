# Shows API v2 — Student Instructions

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

1. Click on **GET** `/api/v2/shows`
2. Click **"Try it out"**
3. Click **"Execute"**
4. The response will appear below with the list of shows:

```json
[
  { "id": 1, "titulo": "Iron Maidem", "genero": "Rock", "cidade": "Belo Horizonte" },
  { "id": 2, "titulo": "Gueta Van Fleet", "genero": "Rock", "cidade": "São Paulo" },
  { "id": 3, "titulo": "Metallica", "genero": "Rock", "cidade": "Belo Horizonte" }
]
```

### Try GET a single show

1. Click on **GET** `/api/v2/shows/{id}`
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
   http://localhost:5000/api/v2/shows
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

9. Now go back to Swagger and run **GET** `/api/v2/shows` again — you should see the new show in the list.

---

## 4. Quick Reference — All Endpoints

| Method   | URL                         | Description               |
|----------|-----------------------------|---------------------------|
| GET      | /api/v2/shows               | Get all shows             |
| GET      | /api/v2/shows/{id}          | Get a show by ID          |
| POST     | /api/v2/shows               | Create a new show         |
| PUT      | /api/v2/shows/{id}          | Update a show             |
| DELETE   | /api/v2/shows/{id}          | Delete a show by ID       |
| DELETE   | /api/v2/shows               | Delete all shows          |
| DELETE   | /api/v2/shows/batch         | Delete multiple shows     |

---

## 5. Show Object Structure

```json
{
  "titulo": "string",
  "genero": "string",
  "cidade": "string"
}
```

---

## 6. Deleting All Shows with Postman

1. Open **Postman**
2. Set the method to **DELETE**
3. Enter the URL:
   ```
   http://localhost:5000/api/v2/shows
   ```
4. Click **Send**

**Status:** `204 No Content`

---

## 7. Deleting Multiple Shows by ID with Postman

1. Open **Postman**
2. Set the method to **DELETE**
3. Enter the URL:
   ```
   http://localhost:5000/api/v2/shows/batch
   ```
4. Go to the **Body** tab
5. Select **raw** and choose **JSON** from the dropdown on the right
6. Paste a JSON array of IDs to delete:

```json
[1, 2, 3]
```

7. Click **Send**

**Status:** `204 No Content`
