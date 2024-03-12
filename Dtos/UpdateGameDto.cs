﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.api.Dtos;

public record class UpdateGameDto(
    [Required][StringLength(50)]string Name,
    int GenreId,
    [Range(1, 5000)] decimal Price,
    DateOnly ReleaseDate
    );