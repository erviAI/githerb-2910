# Let's build githerb - In python

## Prepare python environment

```shell
python -m venv venv

source ./venv/bin/activate

pip install -r requirements.txt
```

## Start FastAPI server (with hot-reload)

```shell
python -m main
```

Server can be shut down by pressing 

CTRL / CMD &#8984; + C

## Run tests

```shell
python -m pytest
```