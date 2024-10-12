# Bekk Hello World
![.NET Badge](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge)
![Docker Badge](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=fff&style=for-the-badge)

This image contains a simple web application written in .Net that outputs a simple response that can be customized through
an environment variable.

## Getting started
The application is packaged as a docker container and can run anywhere where you can run a docker container.

### Locally
In order to test the image locally, simply run:
```bash
docker run --rm -p 127.0.0.1:8080:8080 -e SITE__GREETING=$(whoami) -e SITE__FROM="Bekk" ghcr.io/andersro93/bekk-hello-world:latest
```
You can then open a browser and navigate to [http://localhost:8080](http://localhost:8080).
