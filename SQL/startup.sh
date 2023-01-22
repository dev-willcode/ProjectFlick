docker build --pull --rm -f "Dockerfile" -t projectflick-db:latest .
docker run -it --env-file .\.env -p 1433:1433 --name projectflick-db projectflick-db