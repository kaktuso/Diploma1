# Diploma1.WebApi

## Запуск

1. Проверьте строку подключения в `appsettings.json`.
2. Выполните миграции базы данных:
   ```
   dotnet ef database update --project ../Diploma1.Infrastructure/Diploma1.Infrastructure.csproj --startup-project ./Diploma1.WebApi.csproj
   ```
3. Запустите проект:
   ```
   dotnet run --project ./Diploma1.WebApi.csproj
   ```
4. Swagger UI будет доступен по адресу `/swagger`.

## Роли
- Администратор
- Инженер по охране труда
- Сотрудник

## Контроллеры
- `/api/Employee`
- `/api/Department`
- `/api/Workplace`
- `/api/Attestation`
- `/api/RegulatoryDocument`
- `/api/Monitoring`
- `/api/Auth`

## Примечания
- Для авторизации используйте JWT или куки (Identity).
- Для фоновых задач используется Hangfire (`/hangfire`).
- Для email-уведомлений настройте SMTP в `appsettings.json`.
