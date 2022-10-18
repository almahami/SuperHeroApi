query{
superheroes{
name,
description,

}
}


query{
superheroes{
name,
description,
superpowers(order: {superPower:DESC}){
superPower,
description
}
}
}


query{
superheroes{
name,
description,
superpowers(order: {superPower:DESC}){
superPower,
description
}
movies(order: {title: DESC}){
title
}
}
}

query{
movies {
title
}
}

query{
movies {
title
instructor
releaseDate
superhero{
name
}
}
}

query{
superpowers {
superPower
description
}
}


query{
superpowers(where: {superPower: {eq: "Infiltration"} })
{
superPower
description

}
}

query{
superpowers
{
superPower
description
superheroId
superhero{
name
}
}
}

## TO DO Migration  

dotnet ef migrations add "Initial Migrations"

## TO Update the Database 

dotnet ef database update

## Path 

https://localhost:7262/graphQL/ 