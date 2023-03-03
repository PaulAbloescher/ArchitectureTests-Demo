Start-Process -FilePath "docker" -NoNewWindow -ArgumentList "run --rm --volume ${pwd}:/data pandoc/latex -t beamer -V theme:Luebeck 20230123_Architecture_Tests.md -o 20230123_Architecture_Tests.pdf"
