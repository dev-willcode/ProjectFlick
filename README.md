# ProjectFlick
docker build --pull --rm -f "SQL\Dockerfile" -t projectflick:latest "SQL" 
docker run -it --env-file .\.env -p 1433:1433 --name projectflick-db projectflick