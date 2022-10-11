# ASP.NET Core com Redis

Primeiramente, inicie uma instância do Redis localmente. Eu indico utilizar Docker para isso, com o comando abaixo.

```docker run -d -p 6379:6379 --name redis redis```

Depois disso, eu recomendo instalar um Client Redis, para poder acessar o serviço Redis que está sendo executado, e poder conferir os pares chave-valor salvos.

Eu indico o [Another Redis Desktop Manager](https://github.com/qishibo/AnotherRedisDesktopManager/releases).

Finalmente, você pode executar a aplicação com o comando .NET CLI:  
```dotnet run```
