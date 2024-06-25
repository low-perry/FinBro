using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto toCommentDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                Title = comment.Title,
                Content = comment.Content,
                CreatedOn = comment.CreatedOn,
                StockId = comment.StockId
            };
        }

        public static Comment ToComment(this CreateCommentRequestDto createCommentRequestDto, int stockId)
        {
            return new Comment
            {
                Title = createCommentRequestDto.Title,
                Content = createCommentRequestDto.Content,
                StockId = stockId
            };
        }

        public static Comment ToComment(this UpdateCommentRequestDto updateCommentRequestDto)
        {
            return new Comment
            {
                Title = updateCommentRequestDto.Title,
                Content = updateCommentRequestDto.Content
            };
        }
    }
}