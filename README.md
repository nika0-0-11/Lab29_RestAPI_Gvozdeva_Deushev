# Лабораторная работа №29. REST API: контроллеры и маршруты

---

## Основная информация

**ФИО:** Гвоздева В.А, Деушев Т.Т  
**Группа:** ИСП-231  
**Дата:** 07.04.2026  

---

##  Краткое описание работы

В ходе лабораторной работы были изучены следующие темы:
    - Принципы **Rest**
    - Создание **Web API** на **ASP.NET Core**
    - Создание моделей и **DTO**
    - Добавление доп. маршрутов: поиск, фильтрация, сортировка, статистика

---

## Структура проекта

- Lab29_RestAPI_Gvozdeva_Deushev/
    - img/ 
        - gitPushLab29_Gvozdeva_Deushev.png
        - step2_modelsLab29_Gvozdeva_Deushev.png
        - step3_swaggerLab29_Gvozdeva_Deushev.png
        - step4.1_swaggerTestsLab29_Gvozdeva_Deushev.png
        - step4.2_swaggerTestsLab29_Gvozdeva_Deushev.png
        - step4.3_swaggerTestsLab29_Gvozdeva_Deushev.png
        - step4.4_swaggerTestsLab29_Gvozdeva_Deushev.png
        - step5.1_restClientLab29_Gvozdeva_Deushev.png
        - step5.2_restClientLab29_Gvozdeva_Deushev.png
        - step5.3_restClientLab29_Gvozdeva_Deushev.png
        - step5.4_restClientLab29_Gvozdeva_Deushev.png
        - step6.1_extraRoutesLab29_Gvozdeva_Deushev.png
        - step6.2_extraRoutesLab29_Gvozdeva_Deushev.png
        - step7_programLab29_Gvozdeva_Deushev.png
    - TaskApi/
        - Controllers/ 
            - TasksController.cs
        - Models/
            - CreateTaskDto.cs
            - TaskItem.cs
            - UpdateTaskDto.cs
        - Program.cs
        - requests.http
        - TaskApi.http
        - .editorconfig
        - .gitignore
        - README.md

---

## Список всех реализованных маршрутов

|Метод|Маршрут|
|:---|:-----|
|**GET**|`/api/Tasks`|
|**POSR**|`/api/Tasks`|
|**GET**|`/api/Tasks/{id}`|
|**PUT**|`/api/Tasks/{id}`|
|**DELETE**|`/api/Tasks/{id}`|
|**PATCH**|`/api/Tasks/{id}/complete`|
|**GET**|`/api/Tasks/search`|
|**GET**|`/api/Tasks/priority/{level}`|
|**GET**|`/api/Tasks/stats`|
|**GET**|`/api/Tasks/sorted`|

---

## Итоговая таблица ASP.NET Core Controller-based API

|Аспект|ASP.NET Core Controllers|
|:-----|:-----------------------|
|**Маршруты**|[HttpGet] атрибут над методом|
|**Группировка маршрутов**|Класс-контроллер|
|**Базовый URL**|[Route("api/[controller]")]|
|**Параметр пути**|(int id) — параметр метода|
|**Параметр запроса**|[FromQuery] bool? completed|
|**Тело запроса**|[FromBody] CreateTaskDto dto|
|**Ответ 200**|return Ok(data)|
|**Ответ 201**|return CreatedAtAction(...)|
|**Ответ 404**|return NotFound(...)|
|**Ответ 204**|return NoContent()|
|**Типизация данных**|Строгая (C#)|
|**Документация**|Swagger — устанавливается отдельно|

---

## Главные выводы

1. REST — не протокол, а архитектурный стиль. Те же принципы работают с любым языком и фреймворком.
2. Контроллер в ASP.NET Core = Router в Express, только с автоматической документацией и строгой типизацией.
3. DTO защищает API от некорректных данных: клиент передаёт только то, что сервер разрешает принять.
4. Swagger UI позволяет тестировать API без Postman и без написания тестового JavaScript-кода.
5. Правильные HTTP-статусы — часть «контракта» API. Клиент должен понимать, что произошло, по коду ответа.